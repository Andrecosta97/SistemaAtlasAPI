namespace SistemaAtlasAPI.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int AnoLetivoId { get; set; }
        public AnoLetivo AnoLetivo { get; set; }
        public string? Conteudo { get; set; }
        public DateTime Publicacao { get; set; }
        public DateTime Alteracao { get; set; }
        public int Bimestre { get; set; }
        public bool Publicado { get; set; }
    }
}
