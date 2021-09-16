using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_USERS",
                columns: table => new
                {
                    USU_ID_USER = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USU_TX_NAME = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    USU_TX_DOCUMENT = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USERS", x => x.USU_ID_USER);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_USERS");
        }
    }
}
