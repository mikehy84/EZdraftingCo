using Domain.Entities;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.EmailService
{
    public class SendGridEmailSender : IEmailSender
    {
        private readonly SendGridClient _client;
        private readonly string _from;

        public SendGridEmailSender(IConfiguration config)
        {
            _client = new SendGridClient(config["SendGrid:ApiKey"]);
            _from = config["SendGrid:From"]!;
        }

        public async Task SendAsync(string to, string subject, string body)
        {
            var msg = MailHelper.CreateSingleEmail(
                new EmailAddress(_from),
                new EmailAddress(to),
                subject,
                plainTextContent: null,
                htmlContent: body
            );

            await _client.SendEmailAsync(msg);
        }
    }

}
