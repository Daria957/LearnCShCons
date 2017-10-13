
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace LearnCShCons.learnc.delegateL


{
//    class Student
//    {
//        public void Move(int distance)
//        {
//            for (int i=1; i <= distance; i++)
//            {
//                Thread.Sleep(1000);
//                Console.WriteLine("Идет перемещение ... Пройдено километров: {0}", i);
//            }
//        }

//    }


public delegate void ShowMessege(string messege);
class Student
{
    public void Move(int distance)
    {
        for (int i = 1; i <= distance; i++)
        {
            Thread.Sleep(1000);
                if (Moving != null) {
                    Moving(this, new MovingEventArgs(String.Format("Идет перемещение .... Пройдено километров: {0}", i)));
                }
            
        }
    }
        //public Action<string> Moving { get; set; } // свойство
        public event EventHandler<MovingEventArgs> Moving;
}


}