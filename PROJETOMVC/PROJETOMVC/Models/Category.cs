namespace PROJETOMVC.Models
{
    //essa será a nossa classe de categorias, uma catogira terá muitos lanches
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

        List<Lunch> Lunchs { get; set; }
    }
}
