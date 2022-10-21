using Microsoft.EntityFrameworkCore.Migrations;

namespace e_commerce.Migrations
{
    public partial class ECommerceDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "Usuarioid",
                table: "Producto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Usuarioid",
                table: "Producto",
                column: "Usuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Usuario_Usuarioid",
                table: "Producto",
                column: "Usuarioid",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Usuario_Usuarioid",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_Usuarioid",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Usuarioid",
                table: "Producto");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
