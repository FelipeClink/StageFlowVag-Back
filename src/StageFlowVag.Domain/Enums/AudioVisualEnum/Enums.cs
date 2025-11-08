using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Enums.AudioVisualEnum
{
    public enum TipoRecursoAudiovisual
    {
        Projetor = 1,
        Microfone = 2,
        CaixaSom = 3,
        Notebook = 4,
        Telao = 5,
        Camera = 6,
        Iluminacao = 7,
        MesaSom = 8,
        Outro = 99
    }

    public enum StatusRecurso
    {
        Disponivel = 1,
        EmUso = 2,
        Manutencao = 3,
        Indisponivel = 4
    }

    public enum StatusEvento
    {
        Rascunho = 1,
        AguardandoAprovacao = 2,
        Aprovado = 3,
        EmAndamento = 4,
        Concluido = 5,
        Cancelado = 6,
        Rejeitado = 7
    }

    public enum TipoEvento
    {
        Palestra = 1,
        Workshop = 2,
        Seminario = 3,
        Aula = 4,
        Reuniao = 5,
        Defesa = 6,
        Formatura = 7,
        Outro = 99
    }

    public enum StatusReserva
    {
        Pendente = 1,
        Confirmada = 2,
        EmUso = 3,
        Concluida = 4,
        Cancelada = 5
    }

    public enum SetorResponsavel
    {
        Cerimonial = 1,
        Marketing = 2,
        Audiovisual = 3,
        TI = 4,
        Coordenacao = 5,
        Geral = 6
    }

    public enum PrioridadeTarefa
    {
        Baixa = 1,
        Media = 2,
        Alta = 3,
        Urgente = 4
    }

    public enum StatusTarefa
    {
        Pendente = 1,
        EmAndamento = 2,
        Concluida = 3,
        Atrasada = 4,
        Cancelada = 5
    }
}
