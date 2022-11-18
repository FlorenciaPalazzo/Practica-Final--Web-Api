using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalPalazzoFlorencia.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitales",
                columns: table => new
                {
                    HospitalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", nullable: true),
                    NumCama = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitales", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "Doctores",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHospital = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: true),
                    Especialidad = table.Column<string>(type: "varchar(50)", nullable: true),
                    HospitalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_Doctores_Hospitales_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitales",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_HospitalId",
                table: "Doctores",
                column: "HospitalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctores");

            migrationBuilder.DropTable(
                name: "Hospitales");
        }
    }
}
