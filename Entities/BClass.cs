using BuilderFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BClass
    {
        public BClass()
        {
            Usings = new List<BUsing>();
            Constructors = new List<BConstructor>();
            Properties = new List<BProperty>();
        }

        public string Namespace { get; set; }
        public IList<BUsing> Usings { get; set; }
        public IList<BConstructor>  Constructors { get; set; }
        public IList<BProperty> Properties{ get; set; }

    }
}
