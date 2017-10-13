using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons
{
    public class Student
    {
        private int _age;


        //public int  grow()
        //{
        //    return grow(1);
        //}

        public int Grow(int years)
        {
            Age += years;
            return Age;

        }

        public int Age { get; set; }
       
    }

   

}
