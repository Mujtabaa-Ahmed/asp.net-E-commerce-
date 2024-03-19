using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.Migrations
{
    public partial class ConnectionAndCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_categories",
                columns: table => new
                {
                    cat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cat_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    show_menu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_categories", x => x.cat_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_products",
                columns: table => new
                {
                    p_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    p_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_price_old = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_img_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_img_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_img_3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sub_cat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_products", x => x.p_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_sub_cat",
                columns: table => new
                {
                    sub_cat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sub_cat_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    sub_cat_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_sub_cat", x => x.sub_cat_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_users",
                columns: table => new
                {
                    u_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_users", x => x.u_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_categories");

            migrationBuilder.DropTable(
                name: "tbl_products");

            migrationBuilder.DropTable(
                name: "tbl_sub_cat");

            migrationBuilder.DropTable(
                name: "tbl_users");
        }
    }
}
