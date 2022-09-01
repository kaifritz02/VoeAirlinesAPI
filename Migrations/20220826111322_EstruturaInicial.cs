using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoeAirlines.Migrations
{
    public partial class EstruturaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeronaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fabricante = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Celebridade = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pilotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manutencao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    AeronaveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manutencao_Aeronaves_AeronaveId",
                        column: x => x.AeronaveId,
                        principalTable: "Aeronaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraPartida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraChegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AeronaveId = table.Column<int>(type: "int", nullable: false),
                    PilotoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voos_Aeronaves_AeronaveId",
                        column: x => x.AeronaveId,
                        principalTable: "Aeronaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voos_Pilotos_PilotoId",
                        column: x => x.PilotoId,
                        principalTable: "Pilotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cancelamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataHoraNotificacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VooId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancelamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cancelamentos_Voos_VooId",
                        column: x => x.VooId,
                        principalTable: "Voos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cancelamentos_VooId",
                table: "Cancelamentos",
                column: "VooId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_AeronaveId",
                table: "Manutencao",
                column: "AeronaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Pilotos_Matricula",
                table: "Pilotos",
                column: "Matricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voos_AeronaveId",
                table: "Voos",
                column: "AeronaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Voos_PilotoId",
                table: "Voos",
                column: "PilotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancelamentos");

            migrationBuilder.DropTable(
                name: "Manutencao");

            migrationBuilder.DropTable(
                name: "Voos");

            migrationBuilder.DropTable(
                name: "Aeronaves");

            migrationBuilder.DropTable(
                name: "Pilotos");
        }
    }
}
