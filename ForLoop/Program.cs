using System;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            
            int[] luckyNum={3,6,9,12,15,18};
            for(int i=0;i<luckyNum.Length;i++)
            {
                Console.WriteLine(luckyNum[i]);
            }
            
        }
    }
}
