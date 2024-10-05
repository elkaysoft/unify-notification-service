using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NotificationModelUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationTemplates_NotificationTypes_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationTypes_NotificationTypes_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTypes");

            migrationBuilder.DropIndex(
                name: "IX_NotificationTypes_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTypes");

            migrationBuilder.DropIndex(
                name: "IX_NotificationTemplates_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTemplates");

            migrationBuilder.DropColumn(
                name: "NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTypes");

            migrationBuilder.RenameColumn(
                name: "NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTemplates",
                newName: "NotificationTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "public",
                table: "ScheduledNotifications",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                schema: "public",
                table: "ScheduledNotifications",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Sender",
                schema: "public",
                table: "ScheduledNotifications",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "public",
                table: "ScheduledNotifications",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                schema: "public",
                table: "ScheduledNotifications",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Channel",
                schema: "public",
                table: "ScheduledNotifications",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "public",
                table: "Notifications",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                schema: "public",
                table: "Notifications",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Sender",
                schema: "public",
                table: "Notifications",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "public",
                table: "Notifications",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "ChannelType",
                schema: "public",
                table: "Notifications",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Channel",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "UserPreference",
                table: "EmailTemplateAttachments",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                schema: "UserPreference",
                table: "EmailTemplateAttachments",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "UserPreference",
                table: "EmailTemplateAttachments",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationTypeId",
                schema: "UserPreference",
                table: "NotificationTemplates",
                newName: "NotificationTypeIdId");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "public",
                table: "ScheduledNotifications",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "public",
                table: "ScheduledNotifications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Sender",
                schema: "public",
                table: "ScheduledNotifications",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "public",
                table: "ScheduledNotifications",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Frequency",
                schema: "public",
                table: "ScheduledNotifications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "Channel",
                schema: "public",
                table: "ScheduledNotifications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "public",
                table: "Notifications",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "public",
                table: "Notifications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Sender",
                schema: "public",
                table: "Notifications",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "public",
                table: "Notifications",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "ChannelType",
                schema: "public",
                table: "Notifications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<long>(
                name: "NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Channel",
                schema: "UserPreference",
                table: "NotificationTemplates",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                schema: "UserPreference",
                table: "EmailTemplateAttachments",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                schema: "UserPreference",
                table: "EmailTemplateAttachments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "UserPreference",
                table: "EmailTemplateAttachments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTypes_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTypes",
                column: "NotificationTypeIdId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplates_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTemplates",
                column: "NotificationTypeIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationTemplates_NotificationTypes_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTemplates",
                column: "NotificationTypeIdId",
                principalSchema: "UserPreference",
                principalTable: "NotificationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationTypes_NotificationTypes_NotificationTypeIdId",
                schema: "UserPreference",
                table: "NotificationTypes",
                column: "NotificationTypeIdId",
                principalSchema: "UserPreference",
                principalTable: "NotificationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
