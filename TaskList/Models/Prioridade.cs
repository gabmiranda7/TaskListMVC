using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Prioridade
    {
        [Key]
        [Required(ErrorMessage = "O campo ID é obrigatório!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [MaxLength(50)]
        public string Nome { get; set; }
    }
}
