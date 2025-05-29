using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class AnoLetivo
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public bool Ativo { get; set; } = false;
        public DateTime Início { get; set; }
        public DateTime Fim { get; set; }
        public List<AlunoResponsavel> AlunosResponsaveis { get; set; }
        public List<Turma> Turmas { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

    }
}
