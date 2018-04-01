using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Backend.Migrations
{
    public partial class tabela_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbUsuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(nullable: false),
                    Login = table.Column<string>(type: "varchar(100)", nullable: true),
                    PessoaId = table.Column<Guid>(nullable: false),
                    Senha = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbUsuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_tbUsuario_tbPessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "tbPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbUsuario_PessoaId",
                table: "tbUsuario",
                column: "PessoaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbUsuario");
        }
    }
}
