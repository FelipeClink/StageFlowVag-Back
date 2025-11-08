using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StageFlowVag.Repository.Migrations
{
    /// <inheritdoc />
    public partial class nova_estrutura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blocos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    capacidade = table.Column<int>(type: "integer", nullable: false),
                    localizacao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    observacoes = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blocos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Departamento = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeDisponivel = table.Column<int>(type: "integer", nullable: false),
                    Observacoes = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AlteradoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    matricula = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    telefone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    departamento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "solicitacoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome_evento = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    descricao = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    data_evento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    local = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    publico_estimado = table.Column<int>(type: "integer", nullable: false),
                    aprovado = table.Column<bool>(type: "boolean", nullable: true),
                    data_aprovacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    aprovado_por_id = table.Column<int>(type: "integer", nullable: true),
                    justificativa_rejeicao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    solicitante_id = table.Column<int>(type: "integer", nullable: false),
                    bloco_id = table.Column<int>(type: "integer", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_solicitacoes", x => x.id);
                    table.ForeignKey(
                        name: "FK_solicitacoes_Usuario_solicitante_id",
                        column: x => x.solicitante_id,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_solicitacoes_blocos_bloco_id",
                        column: x => x.bloco_id,
                        principalTable: "blocos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "atendimento_departamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    solicitacao_id = table.Column<int>(type: "integer", nullable: false),
                    departamento = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    responsavel_id = table.Column<int>(type: "integer", nullable: true),
                    data_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    data_conclusao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    observacoes = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atendimento_departamento", x => x.id);
                    table.ForeignKey(
                        name: "FK_atendimento_departamento_Usuario_responsavel_id",
                        column: x => x.responsavel_id,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_atendimento_departamento_solicitacoes_solicitacao_id",
                        column: x => x.solicitacao_id,
                        principalTable: "solicitacoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "disponibilidade_blocos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bloco_id = table.Column<int>(type: "integer", nullable: false),
                    data_hora_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_hora_fim = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    solicitacao_id = table.Column<int>(type: "integer", nullable: true),
                    observacoes = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disponibilidade_blocos", x => x.id);
                    table.ForeignKey(
                        name: "FK_disponibilidade_blocos_blocos_bloco_id",
                        column: x => x.bloco_id,
                        principalTable: "blocos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_disponibilidade_blocos_solicitacoes_solicitacao_id",
                        column: x => x.solicitacao_id,
                        principalTable: "solicitacoes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SolicitacaoInsumos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SolicitacaoId = table.Column<int>(type: "integer", nullable: false),
                    InsumoId = table.Column<int>(type: "integer", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    Observacoes = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AlteradoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoInsumos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitacaoInsumos_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoInsumos_solicitacoes_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "solicitacoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_atendimento_departamento",
                table: "atendimento_departamento",
                column: "departamento");

            migrationBuilder.CreateIndex(
                name: "idx_atendimento_solicitacao",
                table: "atendimento_departamento",
                column: "solicitacao_id");

            migrationBuilder.CreateIndex(
                name: "idx_atendimento_status",
                table: "atendimento_departamento",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_atendimento_departamento_responsavel_id",
                table: "atendimento_departamento",
                column: "responsavel_id");

            migrationBuilder.CreateIndex(
                name: "idx_blocos_nome",
                table: "blocos",
                column: "nome");

            migrationBuilder.CreateIndex(
                name: "idx_disponibilidade_bloco",
                table: "disponibilidade_blocos",
                column: "bloco_id");

            migrationBuilder.CreateIndex(
                name: "idx_disponibilidade_periodo",
                table: "disponibilidade_blocos",
                columns: new[] { "data_hora_inicio", "data_hora_fim" });

            migrationBuilder.CreateIndex(
                name: "idx_disponibilidade_status",
                table: "disponibilidade_blocos",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_disponibilidade_blocos_solicitacao_id",
                table: "disponibilidade_blocos",
                column: "solicitacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoInsumos_InsumoId",
                table: "SolicitacaoInsumos",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoInsumos_SolicitacaoId",
                table: "SolicitacaoInsumos",
                column: "SolicitacaoId");

            migrationBuilder.CreateIndex(
                name: "idx_solicitacoes_aprovado",
                table: "solicitacoes",
                column: "aprovado");

            migrationBuilder.CreateIndex(
                name: "idx_solicitacoes_bloco",
                table: "solicitacoes",
                column: "bloco_id");

            migrationBuilder.CreateIndex(
                name: "idx_solicitacoes_data",
                table: "solicitacoes",
                column: "data_evento");

            migrationBuilder.CreateIndex(
                name: "idx_solicitacoes_solicitante",
                table: "solicitacoes",
                column: "solicitante_id");

            migrationBuilder.CreateIndex(
                name: "idx_usuarios_email",
                table: "Usuario",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_usuarios_matricula",
                table: "Usuario",
                column: "matricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_usuarios_role",
                table: "Usuario",
                column: "role");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atendimento_departamento");

            migrationBuilder.DropTable(
                name: "disponibilidade_blocos");

            migrationBuilder.DropTable(
                name: "SolicitacaoInsumos");

            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "solicitacoes");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "blocos");
        }
    }
}
