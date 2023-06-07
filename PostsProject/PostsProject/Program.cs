using PostsProject.Entitities;

namespace PostProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //podemos fazer tudo por parametros ou adicionar depois, essa seria a forma por parametros
            Post postOne = new Post(DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wornderful country!",
                12
                );

            Comment commentOne = new Comment("Have a nice trip");
            Comment commentTwo = new Comment("Wow that's awesome!");

            postOne.AddComment(commentOne);
            postOne.AddComment(commentTwo);
            
            //essa seria a formar passando um de cada vez
            Post postTwo = new Post();
            postTwo.Moment = DateTime.Parse("28/07/2018 23:14:19");
            postTwo.Title = "Good night guys";
            postTwo.Content = "See you tomorrow";
            postTwo.Likes = 5;

            Comment commentThree = new Comment();
            commentThree.Text = "Good night";

            Comment commentFour = new Comment();
            commentFour.Text = "May the Force be with you";

            postTwo.AddComment(commentThree);
            postTwo.AddComment(commentFour);

            Console.WriteLine(postOne);
            Console.WriteLine("");
            Console.WriteLine(postTwo);



        }
    }
}