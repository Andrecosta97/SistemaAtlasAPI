using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public required string Nome { get; set; }
        public required DateTime DataNascimento { get; set; }
        public required bool Sexo { get; set; }
        public required string Naturalidade { get; set; }
        public required string Matricula { get; set; }        
        public string? EscolaAnterior { get; set; }
        public string? SerieAnterior { get; set; }
        public string? CertidaoRg { get; set; }
        public int? Folha { get; set; }
        public string? CertidaoEstado { get; set; }
        public bool Ativo { get; set; } = true;
        public ICollection<AlunoResponsavel> Responsaveis { get; set; }
        public ICollection<AlunoTurma> AlunoTurmas { get; set; } = new List<AlunoTurma>();


    }
}
