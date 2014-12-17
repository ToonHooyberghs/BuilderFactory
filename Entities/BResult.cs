using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BResult
    {
        public BClass BClass { get; private set; }
        public string Builder { get; private set; }

        public BResult(BClass bClass, string builder)
        {
            BClass = bClass;
            Builder = builder;
        }
    }
}
