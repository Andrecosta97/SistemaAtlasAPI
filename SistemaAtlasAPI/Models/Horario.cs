using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int TurmaId { get; set; }
        public int DiaSemana { get; set; } // 0: Domingo, 1: Segunda, ..., 6: Sábado
        public TimeSpan Inicio { get; set; } // Horário de início
        public TimeSpan Fim { get; set; } // Horário de término
        public Turma Turma { get; set; } // Navegação para a turma associada
        
        public override string ToString()
        {
            return $"{Turma.Nome} - {DiaSemana} - {Inicio} a {Fim}";
        }
    }
}
