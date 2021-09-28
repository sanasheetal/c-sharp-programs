using System;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("jack", "Mechanical", 3.9);
            Student student2 = new Student("elsa", "computer science", 5.5);

            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());
        }
    }
}