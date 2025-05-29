using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class Observacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int Bimestre { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int? AnoLetivoId { get; set; }
        public AnoLetivo? AnoLetivo { get; set; } = null!;
    }
}
