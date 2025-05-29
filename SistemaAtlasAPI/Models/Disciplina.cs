using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Sigla { get; set; }
        public int Prioridade { get; set; }
        public ICollection<ProfessorTurmaDisciplina> ProfessoresTurmas { get; set; }
        public int? AnoLetivoId { get; set; }
        public AnoLetivo? AnoLetivo { get; set; } = null!;

    }
}
