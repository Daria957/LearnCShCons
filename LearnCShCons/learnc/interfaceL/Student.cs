using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons.learnc.interfaceL
{
    public struct Student:IComparable
    {
        public string Name { set; get; }
        public int Age { set; get; }

        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            if (this.Age > student.Age) return 1;
            if (this.Age < student.Age) return -1;
            return 0;

        }
    }
}
