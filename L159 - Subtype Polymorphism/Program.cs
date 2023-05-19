using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L159___Subtype_Polymorphism
{
    public class SuperClass
    {
        public virtual bool MethodName(int parameter)
        {
            return true;
        }
    }
    public class SubClass : SuperClass
    {
        public override bool MethodName(int parameter)
        {
            return !base.MethodName(parameter);
        }
    }

    internal class Program
    {
        static void DoIt(SuperClass item)
        {
            Console.WriteLine(item.MethodName(0));
        }

        static void Main(string[] args)
        {
            SuperClass super = new SuperClass();
            SubClass sub = new SubClass();

            Console.WriteLine(super.MethodName(0));
            Console.WriteLine(sub.MethodName(0));

            // Using a list
            List<SuperClass> list = new List<SuperClass>();
            list.Add(super);
            list.Add(sub);

            foreach (SuperClass item in list)
            {
                Console.WriteLine(item.MethodName(0));
            }

            // Using a subroutine
            DoIt(super);
            DoIt(sub);

            // Using casting
            SuperClass itsReallySub = sub;
            Console.WriteLine(itsReallySub.MethodName(0));
            SubClass backToSub = (SubClass) itsReallySub;
            Console.WriteLine(backToSub.MethodName(0));

            //SubClass willItWork = (SubClass)super; // Causes InvalidCastException

            Console.ReadKey();
        }
    }
}
