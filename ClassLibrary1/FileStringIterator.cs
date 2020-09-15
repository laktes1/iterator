using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class FileStringIterator : Iterator
    {
        private int index;
        private FileStringIterable fsIterable { get; set; }

        public FileStringIterator(FileStringIterable fsIterable)
        {
            this.index = 0;
            this.fsIterable = fsIterable;
        }

        public string CurrentItem()
        {
            return this.fsIterable.content[this.index];
        }

        public void First()
        {
            this.index = 0;
        }

        public bool IsDone()
        {
            return (index == this.fsIterable.content.Length);
        }

        public void Next()
        {
            this.index++;
        }
    }
}
