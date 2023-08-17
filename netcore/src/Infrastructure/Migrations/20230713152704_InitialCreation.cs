using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SINIESTROS");

            migrationBuilder.CreateTable(
                name: "SINIESTROS",
                schema: "SINIESTROS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SINIESTROS", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "SINIESTROS",
                table: "SINIESTROS",
                columns: new[] { "Id", "Descripcion", "Direccion", "Estado", "Fecha", "FechaCreacion", "Localidad", "Pais", "Provincia", "Tipo" },
                values: new object[,]
                {
                    { new Guid("a9ec0f7d-4b9d-4311-9280-9c47a737a020"), "Lo choqué 😨", "Av. Corrientes 1234", 1, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CABA", "Argentina", "CABA", "Choque" },
                    { new Guid("eaf74e07-b897-45b9-a4af-106110fb3316"), "Me chocaron 😔", "Av. Corrientes 1234", 1, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CABA", "Argentina", "CABA", "Choque" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SINIESTROS",
                schema: "SINIESTROS");
        }
    }
}
