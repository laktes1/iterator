using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileStringIterator.Lib;
using System.IO;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Iterable iterable1 = CreateFileIterable();
                var iterator1 = iterable1.CreateIterator();
                while (!iterator1.IsDone())
                {
                    Console.WriteLine(iterator1.CurrentItem());
                    iterator1.Next();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("ОШИБКА: {0}", e.Message);
            }
            Console.ReadLine();
        }

        private static Iterable CreateFileIterable()
        {
            return new FileStringIterable("C:\\Users\\student\\test.txt");
        }
    }
}
