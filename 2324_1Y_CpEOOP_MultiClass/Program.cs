using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_MultiClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass1 sc1 = new SampleClass1();
            SampleClass1 sc11 = new SampleClass1();
            SampleClass1 sc12 = new SampleClass1();

            Console.WriteLine(sc1.message);

            sc1.message = "This is the new message";

            Console.WriteLine(sc1.message);
            Console.WriteLine(sc11.message);
            Console.WriteLine(sc12.message);

            Console.WriteLine(sc1.getPMessage());

            sc1.setPMessage(Console.ReadLine());
            Console.WriteLine(sc1.getPMessage());


            ConstructorClass cc1 = new ConstructorClass();
            Console.WriteLine(cc1.getValue());
            ConstructorClass cc2 = new ConstructorClass(22);
            Console.WriteLine(cc2.getValue());
            ConstructorClass cc3 = new ConstructorClass(5,6);
            Console.WriteLine(cc3.getValue());

            int x = 0;
            int y = 0;

            x = y;

            cc1 = cc2;
            cc2 = cc3;

            sc1 = sc11;
            sc11 = sc12;

            Console.ReadKey();
        }
    }
}
