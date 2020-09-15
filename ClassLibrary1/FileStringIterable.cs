using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassLibrary1
{
    public class FileStringIterable : Iterable
    {
        private string path;
        public string[] content;

        public FileStringIterable(string path)
        {
            this.content = File.ReadAllLines(path);
            this.path = path;
        }

        public Iterator CreateIterator()
        {
            Console.Write(" CreateIterator + ");
            return new FileStringIterator(this);
        }
    }
}
