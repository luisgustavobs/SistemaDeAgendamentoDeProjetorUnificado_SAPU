using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAPU.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perifericos",
                columns: table => new
                {
                    IdPeriferico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perifericos", x => x.IdPeriferico);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    IdProfessor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.IdProfessor);
                });

            migrationBuilder.CreateTable(
                name: "Projetores",
                columns: table => new
                {
                    IdProjetor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetores", x => x.IdProjetor);
                });

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    IdAgendamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProfessor = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.IdAgendamento);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Professores_IdProfessor",
                        column: x => x.IdProfessor,
                        principalTable: "Professores",
                        principalColumn: "IdProfessor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiaAgendados",
                columns: table => new
                {
                    IdDiaAgendado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAgendamento = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaAgendados", x => x.IdDiaAgendado);
                    table.ForeignKey(
                        name: "FK_DiaAgendados_Agendamentos_IdAgendamento",
                        column: x => x.IdAgendamento,
                        principalTable: "Agendamentos",
                        principalColumn: "IdAgendamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAgendamento = table.Column<int>(type: "int", nullable: false),
                    IdProjetor = table.Column<int>(type: "int", nullable: false),
                    IdProfessor = table.Column<int>(type: "int", nullable: false),
                    Sala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioRetirada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.IdRegistro);
                    table.ForeignKey(
                        name: "FK_Registros_Agendamentos_IdAgendamento",
                        column: x => x.IdAgendamento,
                        principalTable: "Agendamentos",
                        principalColumn: "IdAgendamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registros_Professores_IdProfessor",
                        column: x => x.IdProfessor,
                        principalTable: "Professores",
                        principalColumn: "IdProfessor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registros_Projetores_IdProjetor",
                        column: x => x.IdProjetor,
                        principalTable: "Projetores",
                        principalColumn: "IdProjetor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosPerifericos",
                columns: table => new
                {
                    IdRegistroPeriferico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRegistro = table.Column<int>(type: "int", nullable: false),
                    IdPeriferico = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosPerifericos", x => x.IdRegistroPeriferico);
                    table.ForeignKey(
                        name: "FK_RegistrosPerifericos_Perifericos_IdPeriferico",
                        column: x => x.IdPeriferico,
                        principalTable: "Perifericos",
                        principalColumn: "IdPeriferico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistrosPerifericos_Registros_IdRegistro",
                        column: x => x.IdRegistro,
                        principalTable: "Registros",
                        principalColumn: "IdRegistro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_IdProfessor",
                table: "Agendamentos",
                column: "IdProfessor");

            migrationBuilder.CreateIndex(
                name: "IX_DiaAgendados_IdAgendamento",
                table: "DiaAgendados",
                column: "IdAgendamento");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_IdAgendamento",
                table: "Registros",
                column: "IdAgendamento");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_IdProfessor",
                table: "Registros",
                column: "IdProfessor");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_IdProjetor",
                table: "Registros",
                column: "IdProjetor");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosPerifericos_IdPeriferico",
                table: "RegistrosPerifericos",
                column: "IdPeriferico");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosPerifericos_IdRegistro",
                table: "RegistrosPerifericos",
                column: "IdRegistro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaAgendados");

            migrationBuilder.DropTable(
                name: "RegistrosPerifericos");

            migrationBuilder.DropTable(
                name: "Perifericos");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Projetores");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
