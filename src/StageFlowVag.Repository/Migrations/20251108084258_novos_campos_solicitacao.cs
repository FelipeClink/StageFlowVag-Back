using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StageFlowVag.Repository.Migrations
{
    /// <inheritdoc />
    public partial class novos_campos_solicitacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "checklist_item");

            migrationBuilder.DropTable(
                name: "reserva_recurso");

            migrationBuilder.DropTable(
                name: "eventos");

            migrationBuilder.DropTable(
                name: "recurso_audiovisual");

            migrationBuilder.AddColumn<DateTime>(
                name: "data_hora_fim",
                table: "solicitacoes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_hora_inicio",
                table: "solicitacoes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "nomeSocilitante",
                table: "solicitacoes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data_hora_fim",
                table: "solicitacoes");

            migrationBuilder.DropColumn(
                name: "data_hora_inicio",
                table: "solicitacoes");

            migrationBuilder.DropColumn(
                name: "nomeSocilitante",
                table: "solicitacoes");

            migrationBuilder.CreateTable(
                name: "eventos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    coordenador_id = table.Column<int>(type: "integer", nullable: false),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    curso_vinculado = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_fim = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    descricao = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    email_coordenador = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    local = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    nome_coordenador = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    observacoes_gerais = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    publico_estimado = table.Column<int>(type: "integer", nullable: false),
                    requer_cerimonial = table.Column<bool>(type: "boolean", nullable: false),
                    requer_divulgacao = table.Column<bool>(type: "boolean", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    tipo_evento = table.Column<int>(type: "integer", nullable: false),
                    titulo = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "recurso_audiovisual",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    descricao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    numero_patrimonio = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    observacoes = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    quantidade_disponivel = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    tipo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recurso_audiovisual", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "checklist_item",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    evento_id = table.Column<int>(type: "integer", nullable: false),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_conclusao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    data_limite = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    descricao = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    gerado_automaticamente = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    observacoes_conclusao = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    prioridade = table.Column<int>(type: "integer", nullable: false),
                    responsavel_nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    setor_responsavel = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    titulo = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checklist_item", x => x.id);
                    table.ForeignKey(
                        name: "FK_checklist_item_eventos_evento_id",
                        column: x => x.evento_id,
                        principalTable: "eventos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reserva_recurso",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    evento_id = table.Column<int>(type: "integer", nullable: false),
                    recurso_id = table.Column<int>(type: "integer", nullable: false),
                    alterado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_hora_devolucao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    data_hora_entrega = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    data_hora_fim = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_hora_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deletado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    observacoes_reserva = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    quantidade = table.Column<int>(type: "integer", nullable: false),
                    responsavel_devolucao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    responsavel_entrega = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserva_recurso", x => x.id);
                    table.ForeignKey(
                        name: "FK_reserva_recurso_eventos_evento_id",
                        column: x => x.evento_id,
                        principalTable: "eventos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reserva_recurso_recurso_audiovisual_recurso_id",
                        column: x => x.recurso_id,
                        principalTable: "recurso_audiovisual",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "idx_checklist_data_limite",
                table: "checklist_item",
                column: "data_limite");

            migrationBuilder.CreateIndex(
                name: "idx_checklist_evento",
                table: "checklist_item",
                column: "evento_id");

            migrationBuilder.CreateIndex(
                name: "idx_checklist_setor",
                table: "checklist_item",
                column: "setor_responsavel");

            migrationBuilder.CreateIndex(
                name: "idx_checklist_status",
                table: "checklist_item",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "idx_eventos_coordenador",
                table: "eventos",
                column: "coordenador_id");

            migrationBuilder.CreateIndex(
                name: "idx_eventos_data_inicio",
                table: "eventos",
                column: "data_inicio");

            migrationBuilder.CreateIndex(
                name: "idx_eventos_local",
                table: "eventos",
                column: "local");

            migrationBuilder.CreateIndex(
                name: "idx_eventos_status",
                table: "eventos",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "idx_recursos_patrimonio",
                table: "recurso_audiovisual",
                column: "numero_patrimonio");

            migrationBuilder.CreateIndex(
                name: "idx_recursos_status",
                table: "recurso_audiovisual",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "idx_recursos_tipo",
                table: "recurso_audiovisual",
                column: "tipo");

            migrationBuilder.CreateIndex(
                name: "idx_reservas_evento",
                table: "reserva_recurso",
                column: "evento_id");

            migrationBuilder.CreateIndex(
                name: "idx_reservas_periodo",
                table: "reserva_recurso",
                columns: new[] { "data_hora_inicio", "data_hora_fim" });

            migrationBuilder.CreateIndex(
                name: "idx_reservas_recurso",
                table: "reserva_recurso",
                column: "recurso_id");

            migrationBuilder.CreateIndex(
                name: "idx_reservas_status",
                table: "reserva_recurso",
                column: "status");
        }
    }
}
