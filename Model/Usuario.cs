using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMySql.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string NomeCompleto { get; set; }
        public string DataNascimento { get; set; }
        public bool UsuarioContribuidor { get; set; }
    }
}
