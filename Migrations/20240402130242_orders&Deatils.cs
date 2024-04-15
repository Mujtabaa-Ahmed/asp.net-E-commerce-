using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.Migrations
{
    public partial class ordersDeatils : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Orders",
                columns: table => new
                {
                    Order_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_userId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_toatlAmount = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Orders", x => x.Order_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Orders_Detail",
                columns: table => new
                {
                    Orders_details_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_userId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orders_Details_product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orders_details_Product_price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orders_details_Product_Qty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Orders_Detail", x => x.Orders_details_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Orders");

            migrationBuilder.DropTable(
                name: "tbl_Orders_Detail");
        }
    }
}
