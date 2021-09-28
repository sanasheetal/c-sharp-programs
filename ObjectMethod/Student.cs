using System;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethod
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName,string aMajor,double aGpa)
        {
            name=aName;
            major=aMajor;
            gpa=aGpa;
        }

        public bool HasHonours()
        {
            if(gpa>=4.5)
            {
                return true;
            }
            return false;
        }

    }
}