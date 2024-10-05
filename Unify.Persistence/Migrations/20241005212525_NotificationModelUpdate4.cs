using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NotificationModelUpdate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RetriesLeft",
                schema: "public",
                table: "ScheduledNotifications");

            migrationBuilder.AddColumn<int>(
                name: "RetryCount",
                schema: "public",
                table: "Notifications",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RetryCount",
                schema: "public",
                table: "Notifications");

            migrationBuilder.AddColumn<int>(
                name: "RetriesLeft",
                schema: "public",
                table: "ScheduledNotifications",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
