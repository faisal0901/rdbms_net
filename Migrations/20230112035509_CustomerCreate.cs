using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tokonyadia.Migrations
{
    /// <inheritdoc />
    public partial class CustomerCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "customer",
                schema: "dbo",
                columns: table => new
                {
                    customerid = table.Column<int>(name: "customer_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customername = table.Column<string>(name: "customer_name", type: "NVarchar(100)", nullable: false),
                    phonenumber = table.Column<string>(name: "phone_number", type: "NVarchar(14)", nullable: false),
                    address = table.Column<string>(type: "varchar(250)", nullable: false),
                    email = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.customerid);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    storeid = table.Column<int>(name: "store_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storename = table.Column<string>(name: "store_name", type: "NVarchar(100)", nullable: false),
                    phonenumber = table.Column<string>(name: "phone_number", type: "NVarchar(14)", nullable: false),
                    address = table.Column<string>(type: "varchar(250)", nullable: false),
                    siupnumber = table.Column<string>(name: "siup_number", type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.storeid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_email",
                schema: "dbo",
                table: "customer",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "IX_customer_phone_number",
                schema: "dbo",
                table: "customer",
                column: "phone_number");

            migrationBuilder.CreateIndex(
                name: "IX_Store_phone_number",
                table: "Store",
                column: "phone_number");

            migrationBuilder.CreateIndex(
                name: "IX_Store_siup_number",
                table: "Store",
                column: "siup_number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
