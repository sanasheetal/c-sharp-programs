using System;
using System.Text;
using System.Threading.Tasks;

namespace Caluculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Building a better Caluculator
            
            Console.Write("Enter a Number : ");
            double num1= Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter operator: ");
            string op=Console.ReadLine();
            
            Console.Write("Enter a Number : ");
            double num2= Convert.ToDouble(Console.ReadLine());

            if(op=="+")
            {
                Console.WriteLine(num1+num2);
            }
            else if(op=="-")
            {
                Console.WriteLine(num1-num2);
            }
            else if(op=="/")
            {
                Console.WriteLine(num1/num2);
            }
            else if(op=="*")
            {
                Console.WriteLine(num1*num2);
            }
            else if(op=="%")
            {
                Console.WriteLine(num1%num2);
            }
            else
            {
                Console.WriteLine("inavlid");
            }
            
        }
    }
}
