﻿// <auto-generated />
using System;
using Daniel_Montero_Ap1_pFinal.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Daniel_Montero_Ap1_pFinal.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220412005958_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Asistencia", b =>
                {
                    b.Property<int>("AsistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ausente")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("GrupoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Presente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("estudianteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AsistenciaId");

                    b.ToTable("Asistencia");
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.AsistenciaDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AsistenciaId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Asistio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ausente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Presente")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AsistenciaId");

                    b.ToTable("AsistenciaDetalle");
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Aulas", b =>
                {
                    b.Property<int>("AulaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AulaId");

                    b.ToTable("Aulas");
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CursoId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Estudiantes", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ausente")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Presente")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");

                    b.HasData(
                        new
                        {
                            EstudianteId = 1,
                            Apellido = "Teto",
                            Ausente = 0,
                            Direccion = "Teteo ramirez#57",
                            Email = "Teteo57@gmail.com",
                            Nombre = "Mario",
                            Presente = 0,
                            Sexo = "M",
                            Telefono = 809028329
                        },
                        new
                        {
                            EstudianteId = 2,
                            Apellido = "Delta",
                            Ausente = 0,
                            Direccion = "Teteo ramirez#57",
                            Email = "Maria57@gmail.com",
                            Nombre = "Luigi",
                            Presente = 0,
                            Sexo = "F",
                            Telefono = 809323423
                        },
                        new
                        {
                            EstudianteId = 3,
                            Apellido = "Mosquea",
                            Ausente = 0,
                            Direccion = "Alcariso ramirez#57",
                            Email = "Molineo57@gmail.com",
                            Nombre = "Juan",
                            Presente = 0,
                            Sexo = "F",
                            Telefono = 809323423
                        });
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Grupos", b =>
                {
                    b.Property<int>("GrupoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AulaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CuposDisponible")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionCurso")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.HasKey("GrupoId");

                    b.ToTable("Grupos");

                    b.HasData(
                        new
                        {
                            GrupoId = 1,
                            AulaId = 1,
                            Capacidad = 40,
                            CuposDisponible = 10,
                            CursoId = 1,
                            DescripcionCurso = "Programacion Aplicada",
                            Fecha = new DateTime(2010, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfesorId = 1,
                            Tiempo = 4
                        },
                        new
                        {
                            GrupoId = 2,
                            AulaId = 2,
                            Capacidad = 30,
                            CuposDisponible = 15,
                            CursoId = 2,
                            DescripcionCurso = "Programacion 1",
                            Fecha = new DateTime(2018, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfesorId = 2,
                            Tiempo = 3
                        });
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Nacionalida", b =>
                {
                    b.Property<int>("NacionalidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("TEXT");

                    b.HasKey("NacionalidaId");

                    b.ToTable("Nacionalida");

                    b.HasData(
                        new
                        {
                            NacionalidaId = 1,
                            Nacionalidad = "Republica Dominicana"
                        },
                        new
                        {
                            NacionalidaId = 2,
                            Nacionalidad = "Peru"
                        },
                        new
                        {
                            NacionalidaId = 3,
                            Nacionalidad = "Mexico"
                        },
                        new
                        {
                            NacionalidaId = 4,
                            Nacionalidad = "Estados Unidos"
                        });
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Profesores", b =>
                {
                    b.Property<int>("ProfesorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GrupoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ProfesorId");

                    b.ToTable("Profesores");

                    b.HasData(
                        new
                        {
                            ProfesorId = 1,
                            GrupoId = 1,
                            Nombre = "Mario"
                        },
                        new
                        {
                            ProfesorId = 2,
                            GrupoId = 2,
                            Nombre = "Luigi"
                        });
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.AsistenciaDetalle", b =>
                {
                    b.HasOne("Daniel_Montero_Ap1_pFinal.Entidades.Asistencia", null)
                        .WithMany("asistenciadetalle")
                        .HasForeignKey("AsistenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Daniel_Montero_Ap1_pFinal.Entidades.Asistencia", b =>
                {
                    b.Navigation("asistenciadetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
