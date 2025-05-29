using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string Cor { get; set; }
        public List<AlunoTurma> AlunosTurma { get; set; } = new();
        public ICollection<ProfessorTurmaDisciplina> ProfessoresDisciplinas { get; set; }
        public string Nível { get; set; }
        public int AnoLetivoId { get; set; }
        public AnoLetivo AnoLetivo { get; set; } = null!;
    }
}
