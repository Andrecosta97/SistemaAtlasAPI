using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class Responsavel
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string? Profissao { get; set; }
        public string? GrauParentesco { get; set; }
        public required string CPF { get; set; }
        public string Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public ICollection<AlunoResponsavel> Alunos { get; set; } = new List<AlunoResponsavel>();
    }
}
