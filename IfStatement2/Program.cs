﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(10,20,30));
        }
        static int GetMax(int num1,int num2,int  num3)
        {
            int result;
            if(num1>=num2 && num1>=num3)
            {
                result=num1;
            }
            else if(num2>=num1 && num2>=num3)
            {
                result=num2;
            }
            else{
                result=num3;
            }
            return result;
        }
    }
}
