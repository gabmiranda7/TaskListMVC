using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList.Models
{
    public class Tarefa
    {
        [Display(Name = "ID da Tarefa")]
        [Range( 0, int.MaxValue, ErrorMessage = "Insira um valor válido.")]
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório!")]
        [Display(Name = "Descrição da Tarefa")]
        [MaxLength(255)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Data de Início é obrigatório!")]
        [Display(Name = "Data de Início da Tarefa")]
        [DataType(DataType.Date)]
        public DateTime? DataInicio { get; set; }

        [Display(Name = "Data de Fim da Tarefa")]
        public DateTime? DataFim { get; set; }

        [ForeignKey("Prioridade")]
        [Display(Name = "Prioridade")]
        public int PrioridadeId { get; set; }
        public virtual Prioridade? Prioridade { get; set; }

        [ForeignKey("Categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }

        [ForeignKey("Status")]
        [Display(Name = "Status")]
        public int StatusId { get; set; }
        public virtual Status? Status { get; set; }

        [ForeignKey("Responsavel")]
        [Display(Name = "Responsável")]
        public int ResponsavelId { get; set; }
        public virtual Responsavel? Responsavel { get; set; }


        public DateTime PrazoConclusao { get; set; }

        [MaxLength(5000)]
        public string? Observacao { get; set; }
    }
}
