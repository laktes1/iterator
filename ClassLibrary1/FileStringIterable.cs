using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileStringIterator.Lib
{
    public class FileStringIterable : Iterable
    {
        public string[] content { get; private set; }

        public FileStringIterable(string path)
        {
                this.content = File.ReadAllLines(path);
        }

        public Iterator CreateIterator()
        {
            return new FileStringIterator(this);
        }
    }
}
