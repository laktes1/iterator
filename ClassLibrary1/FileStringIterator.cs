using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class FileStringIterator : Iterator
    {
        private int index;
        private string[] content;

        public FileStringIterator(FileStringIterable fsIterable)
        {
            this.index = 0;
            this.content = fsIterable.content;

        }

        public string CurrentItem()
        {
            return content[index];
            throw new NotImplementedException();
        }

        public void First()
        {
            this.index = 0;
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            if (this.content[index].Length < 1 )
                return false;
            else return true;
            throw new NotImplementedException();
        }

        public void Next()
        {
            this.index++;
            throw new NotImplementedException();
        }
    }
}
