using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crap
{
    class SubClass
    {
        List<string> list = new List<string>();

        public bool AddString(string st)
        {
            list.Add(st);
            return true;
        }

        public int size
        {
            get
            {
                return list.Count;
            }
        }
    }
}
