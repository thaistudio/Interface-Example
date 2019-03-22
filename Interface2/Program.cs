using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            program.method(class1, "thai");
            program.method(class2, "nguyen");
            Console.ReadLine();
        }

        void method(TInt interf, string msg)
        {
            interf.mes = msg;
            interf.IntMeth();
        }
    }

    public interface TInt
    {
        string mes { get; set; }
        void IntMeth();
    }

    class Class1 : TInt
    {
        public string mes { get; set; }

        public void IntMeth()
        {
            Console.WriteLine(mes + " 1"); 
        }
    }

    class Class2 : TInt
    {
        public string mes { get; set; }

        public void IntMeth()
        {
            Console.WriteLine(mes + " 2");
        }
    }
}
