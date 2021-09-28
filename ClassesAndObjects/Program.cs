using System;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes and object
            
            Book book1=new Book();
            book1.title="harry potter";
            book1.author="jk rowling";
            book1.pages=400;

            Book book2=new Book();
            book2.title="jack forst";
            book2.author="sana";
            book2.pages=300;

            Console.WriteLine(book2.title);
            //*/
        }
    }
}
