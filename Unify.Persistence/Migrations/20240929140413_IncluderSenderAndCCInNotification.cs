using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IncluderSenderAndCCInNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CC",
                schema: "public",
                table: "ScheduledNotifications",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sender",
                schema: "public",
                table: "ScheduledNotifications",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CC",
                schema: "public",
                table: "Notifications",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sender",
                schema: "public",
                table: "Notifications",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CC",
                schema: "public",
                table: "ScheduledNotifications");

            migrationBuilder.DropColumn(
                name: "Sender",
                schema: "public",
                table: "ScheduledNotifications");

            migrationBuilder.DropColumn(
                name: "CC",
                schema: "public",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "Sender",
                schema: "public",
                table: "Notifications");
        }
    }
}
