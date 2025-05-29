using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class AlunoResponsavel
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; } = null!;
        public int ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; } = null!;
        public bool Principal { get; set; } = false;
        public int? AnoLetivoId { get; set; }
        public AnoLetivo? AnoLetivo { get; set; } = null!;
    }
}
