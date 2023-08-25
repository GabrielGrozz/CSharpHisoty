using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJETOMVC.Models
{
    //essa será a chasse do nosso lanche, o lanche possui apenas uma categoria
    [Table("Lanches")]
    public class Lunch
    {
        [Required(ErrorMessage ="esse campo precisa ser preenchido")]
        [Display(Name ="ID lanches")]
        [StringLength(100, ErrorMessage ="o máximo possível de adicionar é 100 caracteres")]
        public int LunchId { get; set; }

        [Required(ErrorMessage ="esse campo precisa ser preenchido")]
        [Display(Name ="Nome")]        
        [StringLength(100, ErrorMessage ="é necessário preencher esse campo")]
        public string Name { get; set; }

        [Required(ErrorMessage ="de um desscrição curta")]
        [Display(Name ="Descrição curta")]        
        //podemos definir um tamanho mínimo no StringLenght
        [StringLength(200, MinimumLength =15, ErrorMessage ="A descrição curta deve ter no mínimo {0} e  no máximo {1} caracteres")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage ="de uma descrição longa")]
        [Display(Name ="descrição longa")]
        //podemos também declara o tamanho minimo e máximo separadamente
        [MinLength(30, ErrorMessage ="o minimo de caracteres é 30")]
        [MaxLength(500, ErrorMessage ="o máximo de caracteres é 500")]
        public string LongDescription { get; set; }

        [Required(ErrorMessage ="Defina um preço")]
        [Display(Name ="preço")]
        //o atributo column serve para definirmos propriedades da coluna, aqui definimos um nome e um range de tamanho para os inteiros e decimais
        [Column(TypeName ="decimal(10,2)")]
        //no Range podemos definir um tamanho minimo e maximo de caracteres
        [Range(1,999.99, ErrorMessage ="o preço deve ser de 1 a 999.99")]
        public decimal Price { get; set; }

        [Display(Name ="Imagem")]
        [StringLength(250, MinimumLength =5, ErrorMessage="o tamanho da url deve ser de 5")]
        public string ImageURL { get; set; }

        [Display(Name = "Imagem")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "o tamanho da url deve ser de 5")]
        public string ImageThumbUR { get; set; }

        [Display(Name ="Preferido?")]
        public bool Preferred { get; set; }

        [Display(Name ="Tem estoque?")]
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
