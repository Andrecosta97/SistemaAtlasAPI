using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAtlasAPI.Models;

namespace SistemaAtlasAPI.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<ProfessorTurmaDisciplina> ProfessoresTurmasDisciplinas { get; set; }
        public DbSet<Observacao> Observacoes { get; set; }
        public DbSet<AnoLetivo> AnosLetivos { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Horario> Horarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProfessorTurmaDisciplina>()
                .HasIndex(p => new { p.ProfessorId, p.TurmaId, p.DisciplinaId })
                .IsUnique();

            modelBuilder.Entity<AlunoResponsavel>(entity =>
            {
                entity.HasKey(ar => ar.Id);

                entity.HasOne(ar => ar.Aluno)
                      .WithMany(a => a.Responsaveis)
                      .HasForeignKey(ar => ar.AlunoId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(ar => ar.Responsavel)
                      .WithMany(r => r.Alunos)
                      .HasForeignKey(ar => ar.ResponsavelId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(ar => ar.AnoLetivo)
                      .WithMany()
                      .HasForeignKey(ar => ar.AnoLetivoId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<AlunoResponsavel>()
                .HasKey(ar => new { ar.AlunoId, ar.ResponsavelId, ar.AnoLetivoId });
        }
    }
}
