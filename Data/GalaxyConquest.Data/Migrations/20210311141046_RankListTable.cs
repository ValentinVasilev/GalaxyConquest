using Microsoft.EntityFrameworkCore.Migrations;

namespace GalaxyConquest.Data.Migrations
{
    public partial class RankListTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Accounts_QuizId",
                table: "Accounts");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_QuizId",
                table: "Accounts",
                column: "QuizId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Accounts_QuizId",
                table: "Accounts");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_QuizId",
                table: "Accounts",
                column: "QuizId");
        }
    }
}
