using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            ArithProgression arith = new ArithProgression();
            arith.setStart(6);
            arith.setStep(3);
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext()); 
            Console.WriteLine(arith.getNext());

            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессия");
            GeomProgression geom = new GeomProgression();
            geom.setStart(5);
            geom.setStep(2);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}
