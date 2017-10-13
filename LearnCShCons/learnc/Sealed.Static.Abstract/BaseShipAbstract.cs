using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons.learnc.Sealed.Static.Abstract
{
    public abstract class BaseShipAbstract
    {
        public virtual string Move(int distance)
        {
            return ("Виртуальные методы абстрактный классов можно переопределять, а можно нет. Они общие для всех дочерних классов");

        }
        public virtual string Fight()
        {
            return "Произошел бой!";
        }
        public abstract void Land(int x, int y); //
    }
}
