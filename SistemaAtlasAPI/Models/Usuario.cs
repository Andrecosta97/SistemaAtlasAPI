using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;


namespace SistemaAtlasAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Login { get; set; }
        public required string SenhaHash { get; set; }
        public required string TipoUsuario { get; set; } // Professor, Coordenador, Direção, Secretaria
        public required bool Professor { get; set; }
        public bool Ativo { get; set; }
        public bool TrocarSenha { get; set; }
        public ICollection<ProfessorTurmaDisciplina> ProfessorTurmasDisciplinas { get; set; } = new List<ProfessorTurmaDisciplina>();

    }

}



