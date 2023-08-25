using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJETOMVC.Models
{
    //essa será a nossa classe de categorias, uma catogira terá muitos lanches

    //aqui usamos data annotations para organizar a nossa classe para que ela possa ser mapeada no banco

    //aqui seria o nome da tabela
    [Table("Categorias")]
    public class Category
    {
        //o required define que o campo é obrigatório
        [Required(ErrorMessage ="esse campo precisa ser preenchido")]
        //StringLenght define o tamanho da string que é aceita no banco
        [StringLength(100, ErrorMessage ="o máximo de caracteres aceito é de 100 caracteres")]
        //display define o nome que será exibido no banco
        [Display(Name="ID categoria")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="esse campo precisa ser preenchido")]
        [StringLength(150, ErrorMessage ="o tamanho máximo aceito é 150 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage ="esse campo é obrigatório")]
        [StringLength(300, ErrorMessage ="o máximo de caracteres é 300!")]
        [Display(Name ="Descrição")]
        public string Description { get; set; } 

        List<Lunch> Lunchs { get; set; }
    }
}
