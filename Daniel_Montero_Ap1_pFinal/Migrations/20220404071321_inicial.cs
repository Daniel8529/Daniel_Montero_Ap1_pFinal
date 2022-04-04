using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Daniel_Montero_Ap1_pFinal.Migrations
{
    public partial class inicial : Migration
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
                    Presente = table.Column<string>(type: "TEXT", nullable: true),
                    Ausentes = table.Column<string>(type: "TEXT", nullable: true)
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
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    VecesAsignada = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    VecesInscrito = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Email = table.Column<string>(type: "TEXT", nullable: true)
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
                    Desde = table.Column<string>(type: "TEXT", nullable: true),
                    Hasta = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacidad = table.Column<decimal>(type: "TEXT", nullable: false),
                    CuposDisponible = table.Column<decimal>(type: "TEXT", nullable: false)
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
                name: "AsistenciaDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AsistenciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Asistio = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistenciaDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsistenciaDetalle_Asistencia_AsistenciaId",
                        column: x => x.AsistenciaId,
                        principalTable: "Asistencia",
                        principalColumn: "AsistenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Direccion", "Email", "Nombre", "Sexo", "Telefono" },
                values: new object[] { 1, "Teto", "Teteo ramires#57", "Teteo57@gmail.com", "Pedro", "M", 809028329 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Direccion", "Email", "Nombre", "Sexo", "Telefono" },
                values: new object[] { 2, "Molineo", "Teteo ramires#57", "Molineo57@gmail.com", "Maria", "F", 809323423 });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "GrupoId", "AulaId", "Capacidad", "CuposDisponible", "CursoId", "DescripcionCurso", "Desde", "Hasta", "ProfesorId", "Tiempo" },
                values: new object[] { 1, 1, 40m, 10m, 1, "Programacion Aplicada", "01/04/2022", "027/04/2022", 1, 4 });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "GrupoId", "AulaId", "Capacidad", "CuposDisponible", "CursoId", "DescripcionCurso", "Desde", "Hasta", "ProfesorId", "Tiempo" },
                values: new object[] { 2, 2, 30m, 15m, 2, "Programacion 1", "02/04/2022", "020/04/2022", 2, 3 });

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
                name: "IX_AsistenciaDetalle_AsistenciaId",
                table: "AsistenciaDetalle",
                column: "AsistenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsistenciaDetalle");

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
