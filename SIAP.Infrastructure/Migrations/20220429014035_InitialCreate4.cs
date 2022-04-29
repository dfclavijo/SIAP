using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SIAP.Infrastructure.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                schema: "dbo",
                table: "Fees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InternshipId = table.Column<int>(type: "integer", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    CdpNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Internships_InternshipId",
                        column: x => x.InternshipId,
                        principalSchema: "dbo",
                        principalTable: "Internships",
                        principalColumn: "InternshipsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fees_PaymentId",
                schema: "dbo",
                table: "Fees",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_InternshipId",
                schema: "dbo",
                table: "Payment",
                column: "InternshipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_Payment_PaymentId",
                schema: "dbo",
                table: "Fees",
                column: "PaymentId",
                principalSchema: "dbo",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Payment_PaymentId",
                schema: "dbo",
                table: "Fees");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Fees_PaymentId",
                schema: "dbo",
                table: "Fees");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                schema: "dbo",
                table: "Fees");
        }
    }
}
