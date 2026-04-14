using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_vehicles_StatusId",
                table: "vehicles",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_TypeVehicleId",
                table: "vehicles",
                column: "TypeVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_transport_companies_StatusId",
                table: "transport_companies",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptions_StatusId",
                table: "subscriptions",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptions_SubscriptionTypeId",
                table: "subscriptions",
                column: "SubscriptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_persons_IdentificationTypeId",
                table: "persons",
                column: "IdentificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_persons_PersonStatusId",
                table: "persons",
                column: "PersonStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentProviderId",
                table: "payments",
                column: "PaymentProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_StatusId",
                table: "payments",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_notifications_NotificationTypeId",
                table: "notifications",
                column: "NotificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_loads_TypeLoadId",
                table: "loads",
                column: "TypeLoadId");

            migrationBuilder.CreateIndex(
                name: "IX_disputes_ReasonCategoryId",
                table: "disputes",
                column: "ReasonCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_disputes_StatusId",
                table: "disputes",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_chat_rooms_StatusId",
                table: "chat_rooms",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_chat_messages_MessageTypeId",
                table: "chat_messages",
                column: "MessageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_bids_StatusBidsId",
                table: "bids",
                column: "StatusBidsId");

            migrationBuilder.AddForeignKey(
                name: "FK_bids_status_bids_StatusBidsId",
                table: "bids",
                column: "StatusBidsId",
                principalTable: "status_bids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_chat_messages_message_type_MessageTypeId",
                table: "chat_messages",
                column: "MessageTypeId",
                principalTable: "message_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_chat_rooms_status_chat_StatusId",
                table: "chat_rooms",
                column: "StatusId",
                principalTable: "status_chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_disputes_disputes_status_StatusId",
                table: "disputes",
                column: "StatusId",
                principalTable: "disputes_status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_disputes_reason_disputes_ReasonCategoryId",
                table: "disputes",
                column: "ReasonCategoryId",
                principalTable: "reason_disputes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_loads_type_load_TypeLoadId",
                table: "loads",
                column: "TypeLoadId",
                principalTable: "type_load",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_notifications_notification_type_NotificationTypeId",
                table: "notifications",
                column: "NotificationTypeId",
                principalTable: "notification_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_payment_providers_PaymentProviderId",
                table: "payments",
                column: "PaymentProviderId",
                principalTable: "payment_providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_payment_statuses_StatusId",
                table: "payments",
                column: "StatusId",
                principalTable: "payment_statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persons_person_status_PersonStatusId",
                table: "persons",
                column: "PersonStatusId",
                principalTable: "person_status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persons_type_documents_IdentificationTypeId",
                table: "persons",
                column: "IdentificationTypeId",
                principalTable: "type_documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subscriptions_subscription_status_StatusId",
                table: "subscriptions",
                column: "StatusId",
                principalTable: "subscription_status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subscriptions_subscription_type_SubscriptionTypeId",
                table: "subscriptions",
                column: "SubscriptionTypeId",
                principalTable: "subscription_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transport_companies_companies_status_StatusId",
                table: "transport_companies",
                column: "StatusId",
                principalTable: "companies_status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_type_vehicles_TypeVehicleId",
                table: "vehicles",
                column: "TypeVehicleId",
                principalTable: "type_vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_vehicules_status_StatusId",
                table: "vehicles",
                column: "StatusId",
                principalTable: "vehicules_status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bids_status_bids_StatusBidsId",
                table: "bids");

            migrationBuilder.DropForeignKey(
                name: "FK_chat_messages_message_type_MessageTypeId",
                table: "chat_messages");

            migrationBuilder.DropForeignKey(
                name: "FK_chat_rooms_status_chat_StatusId",
                table: "chat_rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_disputes_disputes_status_StatusId",
                table: "disputes");

            migrationBuilder.DropForeignKey(
                name: "FK_disputes_reason_disputes_ReasonCategoryId",
                table: "disputes");

            migrationBuilder.DropForeignKey(
                name: "FK_loads_type_load_TypeLoadId",
                table: "loads");

            migrationBuilder.DropForeignKey(
                name: "FK_notifications_notification_type_NotificationTypeId",
                table: "notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_payment_providers_PaymentProviderId",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_payment_statuses_StatusId",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_person_status_PersonStatusId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_type_documents_IdentificationTypeId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_subscriptions_subscription_status_StatusId",
                table: "subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_subscriptions_subscription_type_SubscriptionTypeId",
                table: "subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_transport_companies_companies_status_StatusId",
                table: "transport_companies");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_type_vehicles_TypeVehicleId",
                table: "vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_vehicules_status_StatusId",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_StatusId",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_TypeVehicleId",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_transport_companies_StatusId",
                table: "transport_companies");

            migrationBuilder.DropIndex(
                name: "IX_subscriptions_StatusId",
                table: "subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_subscriptions_SubscriptionTypeId",
                table: "subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_persons_IdentificationTypeId",
                table: "persons");

            migrationBuilder.DropIndex(
                name: "IX_persons_PersonStatusId",
                table: "persons");

            migrationBuilder.DropIndex(
                name: "IX_payments_PaymentProviderId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_StatusId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_notifications_NotificationTypeId",
                table: "notifications");

            migrationBuilder.DropIndex(
                name: "IX_loads_TypeLoadId",
                table: "loads");

            migrationBuilder.DropIndex(
                name: "IX_disputes_ReasonCategoryId",
                table: "disputes");

            migrationBuilder.DropIndex(
                name: "IX_disputes_StatusId",
                table: "disputes");

            migrationBuilder.DropIndex(
                name: "IX_chat_rooms_StatusId",
                table: "chat_rooms");

            migrationBuilder.DropIndex(
                name: "IX_chat_messages_MessageTypeId",
                table: "chat_messages");

            migrationBuilder.DropIndex(
                name: "IX_bids_StatusBidsId",
                table: "bids");
        }
    }
}
