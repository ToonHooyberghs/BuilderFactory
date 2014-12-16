using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BFindReplace
    {
        public string Find { get; private set; }
        public string Replace { get; private set; }

        public BFindReplace(string find, string replace)
        {
            Find = find;
            Replace = replace;
        }
    }
}
