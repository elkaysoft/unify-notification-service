using Unify.Persistence.Entities;
using Unify.Persistence.Interface;
using Dapper;
using Microsoft.Data.SqlClient;
using Unify.Persistence.Models;
using System.Collections.Generic;
using Unify.Persistence.Enums;
using Npgsql;

namespace Unify.Persistence.DAL
{
    public class NotificationRepo : INotificationRepo
    {
        private string connectionString = Environment.GetEnvironmentVariable("ConnectionString");

        public async Task AddNotification(NotificationRequestLog notification)
        {
            connectionString = Environment.GetEnvironmentVariable("ConnectionString");
            var notificationParams = new 
            {
                recipient = notification.Recipient,
                subject = notification.Subject,
                body = notification.Message,
                channel = notification.ChannelType.ToString(),
                status = NotificationStatus.Pending.ToString(),
                dateCreated = DateTime.Now,
                cc = notification.CC,
                sender = notification.Sender,
                date = DateTime.Now.ToUniversalTime()
            };
            string sql = "INSERT INTO public.\"Notifications\"(\"Recipient\",\"Subject\",\"MessageContent\",\"ChannelType\",\"Status\",\"CC\",\"Sender\", \"DateCreated\") " +
                    "VALUES(@recipient,@subject,@body,@channel,@status,@cc,@sender,@date)";

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            await connection.ExecuteAsync(sql, notificationParams);
            connection.Close();
        }

        public async Task AddNotifications(List<NotificationRequestLog> notifications)
        {
            try
            {
                using var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                foreach (var notification in notifications)
                {
                    var notificationParams = new
                    {
                        recipient = notification.Recipient,
                        subject = notification.Subject,
                        body = notification.Message,
                        channel = notification.ChannelType.ToString(),
                        status = NotificationStatus.Pending.ToString(),
                        cc = notification.CC,
                        sender = notification.Sender,
                        date = DateTime.Now.ToUniversalTime()
                    };

                    string sql = "INSERT INTO public.\"Notifications\"(\"Recipient\",\"Subject\",\"MessageContent\",\"ChannelType\",\"Status\",\"CC\",\"Sender\", \"DateCreated\") " +
                    "VALUES(@recipient,@subject,@body,@channel,@status,@cc,@sender,@date)";
                    await connection.ExecuteAsync(sql, notificationParams);
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
