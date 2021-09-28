using System;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception handeling
            
            try
            {
            Console.Write("enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter a number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(a/b);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //*/
        }
    }
}
