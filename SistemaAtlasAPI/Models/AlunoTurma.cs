namespace SistemaAtlasAPI.Models
{
    public class AlunoTurma
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; } = null!;
        public int TurmaId { get; set; }
        public Turma Turma { get; set; } = null!;
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
        public DateTime? DataDesmatricula { get; set; } = null;
        public string? MotivoDesmatricula { get; set; } = null;
        public string? Observacao { get; set; } = null;
        public ICollection<AlunoTurma> Alunos { get; set; } = new List<AlunoTurma>();

    }
}