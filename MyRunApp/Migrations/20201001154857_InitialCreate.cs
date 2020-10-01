using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRunApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    ShoeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Use = table.Column<string>(nullable: false),
                    Support = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.ShoeId);
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "Brand", "Name", "Support", "Use" },
                values: new object[] { 1, "Brooks", "Ghost 13", "Neutral", "Road Running" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "Brand", "Name", "Support", "Use" },
                values: new object[] { 2, "Hoka", "Tennine", "Stability", "Trail Running" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "Brand", "Name", "Support", "Use" },
                values: new object[] { 31, "Saucany", "Triumph 17 LE", "Neutral", "Road Running" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoes");
        }
    }
}
