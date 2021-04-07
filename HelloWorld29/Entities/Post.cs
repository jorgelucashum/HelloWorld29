using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // namespace do 'StringBuilder'
using System.Threading.Tasks;

namespace HelloWorld29.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        // (Composição) Como a classe 'Comment' contém um relaçao de 'tem muitos' para a classe 'Post' é necessário uma list do tipo 'Comment' para armazenar.
        public List<Comment> Comments { get; set; } = new List<Comment>(); // Instanciando lista vazia.

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // Adicionando um objeto do tipo Comment na lista.
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        // Removendo um objeto do tipo Comment na lista.
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        // StringBuilder é resposável pra fazer a montagem de um string de uma forma mais eficiente e quando tiver feito montado transforma toda a sintaxe em um único 'string', assim não pesando a aplicação.
        // Usar conctenação iria ter que gerar vários strings temporario para cada objeto da lista. 
        public override string ToString()
        { 
            // Construindo o escopo do 'string':
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comentários: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString(); // Convertendo conteúdo do 'StringBuilder' para 'string'. 
            

            // return $"{Title}\n{Likes} Likes - {Moment.ToString("dd/MM/YYYY HH:mm:ss")}\n{Content}\nComentários: {Comments[0]}, {Comments[1]}";
        }
    }


}

