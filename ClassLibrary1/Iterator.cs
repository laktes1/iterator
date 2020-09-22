using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileStringIterator.Lib
{
    public interface Iterator
    {
        void First();
        void Next();
        bool IsDone();
        string CurrentItem();
    }
}
