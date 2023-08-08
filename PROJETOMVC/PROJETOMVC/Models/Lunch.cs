namespace PROJETOMVC.Models
{
    //essa será a chasse do nosso lanche, o lanche possui apenas uma categoria
    public class Lunch
    {
        public int LunchId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumbUR { get; set; }
        public bool Preferred { get; set; }
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
