using System;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods
            
            int cubeNumber=cube(5);
            Console.WriteLine(cubeNumber);            
        }
        static int cube(int num)
        {
            int result=num*num*num;
            return result;
            //*/
        }
    }
}
