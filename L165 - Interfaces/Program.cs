using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L165___Interfaces
{

    public interface IConsumable
    {
        int consume();
        bool isConsumed();
    }

    public interface IDoesDamage
    {
        int getDamage();
    }

    public class Banana : IConsumable, IDoesDamage
    {
        public int consume()
        {
            throw new NotImplementedException();
        }

        public int getDamage()
        {
            throw new NotImplementedException();
        }

        public bool isConsumed()
        {
            throw new NotImplementedException();
        }
    }

    public class Banana2 : Food, IDoesDamage
    {
        private int damage;

        public Banana2(int dmg)
        {
            damage = dmg;
        }

        public int getDamage()
        {
            return damage;
        }
    }

    public class Food : IConsumable
    {
        const int hpWhenConsumed = 10;
        private bool consumed;

        public virtual int consume()
        {
            if (!consumed)
            {
                consumed = true;
                return hpWhenConsumed;
            }
            else
            {
                return 0;
            }
        }

        public bool isConsumed()
        {
            return consumed;
        }

        public string GetName()
        {
            return "I am food.";
        }
    }


    public interface I1
    {
        void a();
    }

    public interface I2
    {
        void a();
        int b();
    }

    public class C1
    {
        public virtual void a()
        {

        }
    }

    public class C2 : C1, I1, I2
    {
        public override void a()
        {
            
        }

        public int b()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food();

            IConsumable c = food;
        }
    }
}
