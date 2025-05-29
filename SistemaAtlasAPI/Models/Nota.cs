using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtlasAPI.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }
        public double N4 { get; set; }
        public double N5 { get; set; }
        public double N6 { get; set; }

        public double Valor()
        {
            return N1! + N2 + N3 + N4 + N5 + N6;  
        }

        public double? ValorRecuperacao { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime? DataAlteracao { get; set; } = DateTime.Now;
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int Bimestre { get; set; }
        public int? AnoLetivoId { get; set; }
        public AnoLetivo? AnoLetivo { get; set; } = null!;
        public bool Publicado { get; set; }

    }
}