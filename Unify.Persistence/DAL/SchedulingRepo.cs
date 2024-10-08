﻿using Dapper;
using Microsoft.Data.SqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Persistence.Entities;
using Unify.Persistence.Enums;
using Unify.Persistence.Interface;
using Unify.Persistence.Models;

namespace Unify.Persistence.DAL
{
    public class SchedulingRepo : ISchedulingRepo
    {
        private string connectionString = Environment.GetEnvironmentVariable("ConnectionString");

        public async Task AddNotification(ScheduledNotificationRequestLog model)
        {
            var reqParams = new
            {
                recipient = model.Recipient,
                subject = model.Subject,
                content = model.Message,
                frequency = model.ScheduleFrequency.ToString(),
                scheduleDate = model.ScheduleDateTime,
                channel = model.ChannelType.ToString(),
                status = NotificationStatus.Pending.ToString(),
                date = DateTime.Now.ToUniversalTime(),    
                cc = model.CC
            };
            string insertSql = "INSERT INTO public.ScheduledNotifications(Recipient,Subject,Content,Frequency,ScheduleDateTime,Channel," +
                "[Status],DateCreated,CC,Sender) VALUES(@recipient,@subject,@content,@frequency,@scheduleDate,@channel,@status,@date,@cc,@sender)";

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            await connection.ExecuteAsync(insertSql, reqParams);
            connection.Close();
        }

        public async Task AddNotifications(List<ScheduledNotificationRequestLog> notifications)
        {
            try
            {
                using var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                foreach (var notification in notifications)
                {
                    var reqParams = new
                    {
                        recipient = notification.Recipient,
                        subject = notification.Subject,
                        content = notification.Message,
                        frequency = notification.ScheduleFrequency.ToString(),
                        scheduleDate = notification.ScheduleDateTime.Value.ToUniversalTime(),
                        channel = notification.ChannelType.ToString(),
                        status = NotificationStatus.Pending.ToString(),
                        date = DateTime.Now.ToUniversalTime(),
                        cc = notification.CC,
                        sender = notification.Sender
                    };
                    string insertSql = "INSERT INTO public.\"ScheduledNotifications\"(\"Recipient\",\"Subject\",\"Content\",\"Frequency\",\"ScheduledDateTime\",\"Channel\"," +
                        "\"Status\",\"DateCreated\",\"CC\",\"Sender\") VALUES(@recipient,@subject,@content,@frequency,@scheduleDate,@channel,@status,@date,@cc,@sender)";

                    await connection.ExecuteAsync(insertSql, reqParams);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }


    }
}
