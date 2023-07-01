using EmployeeLeave.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using EmployeeLeave.Web.Configurations;
using EmployeeLeave.Application.Contracts;
using EmployeeLeave.Application.Repositories;
using Microsoft.AspNetCore.Identity.UI.Services;
using EmployeeLeave.Web.Services;
using Serilog;

namespace EmployeeLeave.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddTransient<IEmailSender>(s => new EmailSender(
                "smtp-relay.gmail.com",
                465,
                "nde95.noreply@gmail.com",
                "CaveBunga1"
            ));
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            builder.Services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
            builder.Services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();

            builder.Services.AddAutoMapper(typeof(MapperConfig));

            builder.Host.UseSerilog((ctx, lc) =>
                lc.WriteTo.Console()
                .ReadFrom.Configuration(ctx.Configuration));
            
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseSerilogRequestLogging();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}