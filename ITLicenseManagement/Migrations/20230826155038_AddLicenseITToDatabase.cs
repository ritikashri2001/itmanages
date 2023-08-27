using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITLicenseManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddLicenseITToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "licenseITs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Portal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderLoadTerm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReSeller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SallerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MicrosoftTenendAdoveVIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenceTerm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Billing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentTerm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RateCommitment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatePerday = table.Column<int>(type: "int", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    ProrateForBilling = table.Column<int>(type: "int", nullable: false),
                    Units = table.Column<int>(type: "int", nullable: false),
                    Ammount = table.Column<int>(type: "int", nullable: false),
                    GSTAmmount = table.Column<int>(type: "int", nullable: false),
                    BillingAmmountWithGST = table.Column<int>(type: "int", nullable: false),
                    TaxInvoiceNumber = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_licenseITs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "licenseITs");
        }
    }
}
