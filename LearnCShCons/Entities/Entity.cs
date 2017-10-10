using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons.Entities
{
    public abstract class Entity<T> where T:Entity<T>
    {
        public virtual Int32 ID { get; protected set; }

        public override Boolean Equals(Object obj)
        {
            var other = obj as T;
            if (other == null) return false;
            var thisIsNew = ID == 0;
            var otherIsNew = other.ID == 0;
            if (thisIsNew && otherIsNew)
             return ReferenceEquals(this, other);
            return ID.Equals(other.ID);
        }

        private Int32? oldHashCode;
        public override Int32 GetHashCode()
        {
            // если у нас есть хэш-код, мы его никогда не изменяем
            if (oldHashCode.HasValue)
                return oldHashCode.Value;
            //когда этот экземпляр сущности новый, мы используем
            //основной хэш -код и запоминаем его, т.о. экземпляр //сущности НИКОГДА не сможет изменить этот хэш-код
            var thisIsNew = ID == 0;
            if (thisIsNew)
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }
            return ID.GetHashCode();
        }

      
        public static Boolean operator ==(Entity<T> lhs, Entity<T> rhs)
        {
            return Equals(lhs, rhs);
        }

        public static Boolean operator !=(Entity<T> lhs, Entity<T> rhs)
        {
            return !Equals(lhs, rhs);
        }

    }
    //public class Pacient : Entity<Pacient>
    //{
    //    public Pacient(string title, string note)
    //    {
    //        Title = title;
    //        Note = note;
    //    }

    //    public Pacient(string title, string note, int iD) : this(title, note)
    //    {
    //        ID = iD;
    //    }

    //    public virtual String Title { get; set; }
    //    public virtual String Note { get; set; }
    //    public override int ID { get => base.ID; protected set => base.ID = value; }

    //    public override bool Equals(object obj)
    //    {
    //        return Equals(other as Name);
    //    }

    //    public override int GetHashCode()
    //    {
            
    //    }

    //    public override string ToString()
    //    {
    //        return base.ToString();
    //    }
    //}

}

