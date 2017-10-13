using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons.learnc.Sealed.Static.Abstract
{
    public class Singleton
    {
        private static Singleton _singleton;
        static Singleton()
        {
            _singleton = new Singleton();
        }
        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get { return _singleton; }
        }
        public int Count { get; set; }
    }
}
