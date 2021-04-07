using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld29.Entities;

namespace HelloWorld29
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Tenha uma boa viagem");
            Comment c2 = new Comment("Isso é incrível!");
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:45:44"), "Viajando para Nova Zelandia", "Eu estou indo visitar este lindo país!", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa Noite");
            Comment c4 = new Comment("Até!");
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:45:40"), "Boa noite pessoal", "Vejo vocês amanhã", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

          
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        } 
    }
}
