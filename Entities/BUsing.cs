using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BUsing
    {
        public string Namespace { get; private set; }

        public BUsing(Type type)
        {
            Namespace = type.Namespace;
        }

        public BUsing(string bNamespace)
        {
            Namespace = bNamespace;
        }
    }
}
