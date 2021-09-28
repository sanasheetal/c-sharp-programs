using System;
using System.Text;
using System.Threading.Tasks;

namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Building exponents
            
            Console.Write("enter base number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter power number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(GetPow(a,b));
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result=1;
            for(int i=0;i<powNum;i++)
            {
                result=result*baseNum;
            }
            return result;
            
        }
    }
}
