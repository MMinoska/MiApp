using Microsoft.EntityFrameworkCore.Migrations;

namespace MiApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asegurados",
                columns: table => new
                {
                    IdAsegurado = table.Column<int>(type: "int", nullable: false),
                    AseguradosName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AseguradosTelefono = table.Column<int>(type: "int", nullable: false),
                    AseguradosEdad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SumaAsegurada = table.Column<int>(type: "int", nullable: false),
                    SumaPrima = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asegurados");

            migrationBuilder.DropTable(
                name: "Seguros");
        }
    }
}
