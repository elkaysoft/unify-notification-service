using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IncludeEmailAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Attachments",
                schema: "public",
                table: "ScheduledNotifications",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attachments",
                schema: "public",
                table: "Notifications",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attachments",
                schema: "public",
                table: "ScheduledNotifications");

            migrationBuilder.DropColumn(
                name: "Attachments",
                schema: "public",
                table: "Notifications");
        }
    }
}
