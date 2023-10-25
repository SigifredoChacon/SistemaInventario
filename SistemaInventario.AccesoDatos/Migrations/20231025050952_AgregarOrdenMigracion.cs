using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaInventario.AccesoDatos.Migrations
{
    public partial class AgregarOrdenMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicationId",
                table: "CarroCompras");

            migrationBuilder.DropIndex(
                name: "IX_CarroCompras_UsuarioAplicationId",
                table: "CarroCompras");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAplicationId",
                table: "CarroCompras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioAplicacionId",
                table: "CarroCompras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioAplicacionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaOrden = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroEnvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalOrden = table.Column<double>(type: "float", nullable: false),
                    EstadoOrden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaMaximoPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransaccionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordenes_AspNetUsers_UsuarioAplicacionId",
                        column: x => x.UsuarioAplicacionId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarroCompras_UsuarioAplicacionId",
                table: "CarroCompras",
                column: "UsuarioAplicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_UsuarioAplicacionId",
                table: "Ordenes",
                column: "UsuarioAplicacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompras",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompras");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropIndex(
                name: "IX_CarroCompras_UsuarioAplicacionId",
                table: "CarroCompras");

            migrationBuilder.DropColumn(
                name: "UsuarioAplicacionId",
                table: "CarroCompras");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAplicationId",
                table: "CarroCompras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarroCompras_UsuarioAplicationId",
                table: "CarroCompras",
                column: "UsuarioAplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicationId",
                table: "CarroCompras",
                column: "UsuarioAplicationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
