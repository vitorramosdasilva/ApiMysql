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

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail não é valido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Senha é requirida")]
        [StringLength(8, ErrorMessage = "Caracteres quantidade entre 5 a 8", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        public string NomeCompleto { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string DataNascimento { get; set; }


        public bool UsuarioContribuidor { get; set; }
    }
}
