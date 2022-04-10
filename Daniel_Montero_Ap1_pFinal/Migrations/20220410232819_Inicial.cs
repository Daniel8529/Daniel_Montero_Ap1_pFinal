using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Daniel_Montero_Ap1_pFinal.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Presente = table.Column<int>(type: "INTEGER", nullable: false),
                    Ausente = table.Column<int>(type: "INTEGER", nullable: false),
                    estudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.AsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    AulaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.AulaId);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellido = table.Column<string>(type: "TEXT", nullable: true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Presente = table.Column<int>(type: "INTEGER", nullable: false),
                    Ausente = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProfesorId = table.Column<int>(type: "INTEGER", nullable: false),
                    DescripcionCurso = table.Column<string>(type: "TEXT", nullable: true),
                    AulaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacidad = table.Column<int>(type: "INTEGER", nullable: false),
                    CuposDisponible = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GrupoId);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalida",
                columns: table => new
                {
                    NacionalidaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nacionalidad = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalida", x => x.NacionalidaId);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    ProfesorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.ProfesorId);
                });

            migrationBuilder.CreateTable(
                name: "AsistenciaDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AsistenciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Asistio = table.Column<bool>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Presente = table.Column<int>(type: "INTEGER", nullable: false),
                    Ausente = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistenciaDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsistenciaDetalles_Asistencia_AsistenciaId",
                        column: x => x.AsistenciaId,
                        principalTable: "Asistencia",
                        principalColumn: "AsistenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Ausente", "Direccion", "Email", "Nombre", "Presente", "Sexo", "Telefono" },
                values: new object[] { 1, "Teto", 0, "Teteo ramirez#57", "Teteo57@gmail.com", "Marioa", 0, "M", 809028329 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Ausente", "Direccion", "Email", "Nombre", "Presente", "Sexo", "Telefono" },
                values: new object[] { 2, "Delta", 0, "Teteo ramirez#57", "Maria57@gmail.com", "Luigi", 0, "F", 809323423 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Ausente", "Direccion", "Email", "Nombre", "Presente", "Sexo", "Telefono" },
                values: new object[] { 3, "Mosquea", 0, "Alcariso ramirez#57", "Molineo57@gmail.com", "Juan", 0, "F", 809323423 });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "GrupoId", "AulaId", "Capacidad", "CuposDisponible", "CursoId", "DescripcionCurso", "Fecha", "ProfesorId", "Tiempo" },
                values: new object[] { 1, 1, 40, 10, 1, "Programacion Aplicada", new DateTime(2010, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "GrupoId", "AulaId", "Capacidad", "CuposDisponible", "CursoId", "DescripcionCurso", "Fecha", "ProfesorId", "Tiempo" },
                values: new object[] { 2, 2, 30, 15, 2, "Programacion 1", new DateTime(2018, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 });

            migrationBuilder.InsertData(
                table: "Nacionalida",
                columns: new[] { "NacionalidaId", "Nacionalidad" },
                values: new object[] { 1, "Republica Dominicana" });

            migrationBuilder.InsertData(
                table: "Nacionalida",
                columns: new[] { "NacionalidaId", "Nacionalidad" },
                values: new object[] { 2, "Peru" });

            migrationBuilder.InsertData(
                table: "Nacionalida",
                columns: new[] { "NacionalidaId", "Nacionalidad" },
                values: new object[] { 3, "Mexico" });

            migrationBuilder.InsertData(
                table: "Nacionalida",
                columns: new[] { "NacionalidaId", "Nacionalidad" },
                values: new object[] { 4, "Estados Unidos" });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "ProfesorId", "GrupoId", "Nombre" },
                values: new object[] { 1, 1, "Mario" });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "ProfesorId", "GrupoId", "Nombre" },
                values: new object[] { 2, 2, "Luigi" });

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaDetalles_AsistenciaId",
                table: "AsistenciaDetalles",
                column: "AsistenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsistenciaDetalles");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Nacionalida");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Asistencia");
        }
    }
}
