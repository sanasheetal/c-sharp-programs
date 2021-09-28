using System;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buliding a Mad lib game
            
            string a,b,c;
            Console.Write("Enter a word: ");
            a = Console.ReadLine();
            
            Console.Write("Enter a word: ");
            b = Console.ReadLine();
            
            Console.Write("Enter a word: ");
            c = Console.ReadLine();

            Console.WriteLine("I am "+a);
            Console.WriteLine("you are "+b);
            Console.WriteLine("we are "+c);
            
        }
    }
}
