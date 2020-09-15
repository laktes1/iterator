using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
//            FileStringIterable iterable1 = new FileStringIterable("C://test.txt");
            FileStringIterable iterable1 = new FileStringIterable("C:\\Users\\student\\test.txt");
            var iterator1 = iterable1.CreateIterator();
            if (iterator1.IsDone())
            {
                Console.WriteLine(" iterator1.IsDone() + ");
                Console.WriteLine( iterator1.CurrentItem());
            }
            //FileStringIterator iterator1 = new FileStringIterator(iterable1);
            Console.ReadLine();
        }
    }
}
