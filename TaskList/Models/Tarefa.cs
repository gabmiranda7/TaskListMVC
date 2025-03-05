using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Tarefa
    {
        [Required(ErrorMessage = "O campo ID é obrigatório!")]
        [Display(Name = "ID da Tarefa")]
        [Range( 0, int.MaxValue, ErrorMessage = "Insira um valor válido.")]
        public int? Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório!")]
        [Display(Name = "Descrição da Tarefa")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Data de Início é obrigatório!")]
        [Display(Name = "Data de Início da Tarefa")]
        [DataType(DataType.Date)]
        public DateTime? DataInicio { get; set; }

        [Display(Name = "Data de Fim da Tarefa")]
        public DateTime? DataFim { get; set; }
    }
}
