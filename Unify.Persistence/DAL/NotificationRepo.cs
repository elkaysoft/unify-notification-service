using Unify.Persistence.Entities;
using Unify.Persistence.Interface;
using Dapper;
using Microsoft.Data.SqlClient;
using Unify.Persistence.Models;
using System.Collections.Generic;
using Unify.Persistence.Enums;

namespace Unify.Persistence.DAL
{
    public class NotificationRepo : INotificationRepo
    {
        private readonly string connectionString = Environment.GetEnvironmentVariable("ConnectionString");

        public async Task AddNotification(NotificationRequestLog notification)
        {
            var notificationParams = new 
            {
                recipient = notification.Recipient,
                subject = notification.Subject,
                body = notification.Message,
                channel = notification.ChannelType.ToString(),
                status = NotificationStatus.Pending.ToString(),
                dateCreated = DateTime.Now,
                cc = notification.CC,
                sender = notification.Sender
            };
            string sql = "INSERT INTO public.Notifications(Recipient,Subject,MessageContent,ChannelType,[Status],DateCreated,CC,Sender) " +
                "VALUES(@recipient,@subject,@body,@channel,@status,@dateCreated,@cc,@sender)";

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            await connection.ExecuteAsync(sql, notificationParams);
            connection.Close();
        }

        public async Task AddNotifications(List<NotificationRequestLog> notifications)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            foreach (var notification in notifications)
            {
                var notificationParams = new
                {
                    recipient = notification.Recipient,
                    subject = notification.Subject,
                    body = notification.Message,
                    channel = notification.ChannelType,
                };

                string sql = "INSERT INTO public.Notifications(Recipient,Subject,MessageContent,ChannelType,[Status],CC,Sender,Attachments) " +
                "VALUES(@recipient,@subject,@body,@channel,@status,@cc,@sender,@attachment)";
                await connection.ExecuteAsync(sql, notificationParams);
            }
            connection.Close();
        }
    }
}
