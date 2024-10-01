using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ModificationToScheduleNotificationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledNotifications_NotificationTypes_NotificationTypeId~",
                schema: "public",
                table: "ScheduledNotifications");

            migrationBuilder.DropIndex(
                name: "IX_ScheduledNotifications_NotificationTypeIdId",
                schema: "public",
                table: "ScheduledNotifications");

            migrationBuilder.DropColumn(
                name: "NotificationTypeIdId",
                schema: "public",
                table: "ScheduledNotifications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NotificationTypeIdId",
                schema: "public",
                table: "ScheduledNotifications",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledNotifications_NotificationTypeIdId",
                schema: "public",
                table: "ScheduledNotifications",
                column: "NotificationTypeIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledNotifications_NotificationTypes_NotificationTypeId~",
                schema: "public",
                table: "ScheduledNotifications",
                column: "NotificationTypeIdId",
                principalSchema: "UserPreference",
                principalTable: "NotificationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
