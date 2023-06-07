using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsProject.Entitities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        //passo importate, aqui iremos ter uma lista com comentários, para que funcione corretamente devemos instanciar uma alista aqui
        //mesmo vazia, ou instancia-la direto no construtor
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }
        public Post(DateTime date, string title, string content, int likes)
        {
            Moment = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //métodos para adicionar e remover comentários   
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //podemos colocar um override para string para logarmos tudo no console apenas chamando a classe
        public override string ToString()
        {
            //o SringBuilder serve para fazermos string de forma inteligente
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes + " Likes - ");
            // temos certas coisas que precisamos converter para string antes de exibirmos, uma delas é o DateTime
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }

            //db.ToString irá converter o conteudo que passamos para string
            return sb.ToString();
        }
    }

}
