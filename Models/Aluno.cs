using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvcEscola.Models
{
    [Table("Alunos")]

    public class Aluno
    {
            [Key]
            public int Id { get; set; }

            [Required]
            public string Nome { get; set; }

            [Required]
            [Display(Name = "Endereço")]
            public string Endereco { get; set; }

            [Required]
            public string Telefone { get; set; }

            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "Data de Nascimento")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime Nascimento { get; set; }

            [Required]
            public bool Ativo { get; set; }
        }
}