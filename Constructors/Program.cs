using System;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructors
            Book book1=new Book("harry potter","jk rowling",400);
            
            Book book2=new Book("jack forst","sana",300);
            
            Console.WriteLine(book2.title);
        }
    }
}
