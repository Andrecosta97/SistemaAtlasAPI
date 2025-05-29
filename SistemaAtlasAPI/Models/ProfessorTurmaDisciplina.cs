using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class ProfessorTurmaDisciplina
    {
        public int Id { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina? Disciplina { get; set; }
        public int ProfessorId { get; set; }
        public Usuario? Professor { get; set; }
        public int TurmaId { get; set; }
        public Turma? Turma { get; set; }
        public int? AnoLetivoId { get; set; }
        public AnoLetivo? AnoLetivo { get; set; }

    }

}
