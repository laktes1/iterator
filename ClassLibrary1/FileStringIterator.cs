using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class FileStringIterator : Iterator
    {
        private int index;

        public FileStringIterator(FileStringIterable fsIterable)
        {
            this.index = 0;
        }

        public string CurrentItem()
        {
            throw new NotImplementedException();
        }

        public void First()
        {
            this.index = 0;
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            this.index++;
            throw new NotImplementedException();
        }
    }
}
