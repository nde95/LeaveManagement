﻿using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace EmployeeLeave.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpServer;
        private int smtpPort;
        private string fromEmailAddress;
        private string emailPassword;
        private readonly bool enableSsl = true;

        public EmailSender(string smtpServer, int smtpPort, string fromEmailAddress, string emailPassword)
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.fromEmailAddress = fromEmailAddress;
            this.emailPassword = emailPassword;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smtpServer, smtpPort);
            client.EnableSsl = enableSsl;
            client.Send(message);

            return Task.CompletedTask;
        }
    }
}
