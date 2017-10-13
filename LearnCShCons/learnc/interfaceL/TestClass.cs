using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons.learnc.interfaceL
{
    class TestClass : Window, resturant
    {
        

        public string GetMenu()
        {
            return "Интерфейс собственный";
        }

         string Window.GetMenu()
        {
            return "Интерфейс Window";

        }
        string resturant.GetMenu()
        {
            return "Интерфейс Restaurant";
        }
    }
}
