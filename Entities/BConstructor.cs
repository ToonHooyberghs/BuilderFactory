using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BConstructor
    {
        public IList<ParameterInfo> Parameters { get; private set; }

        public BConstructor(ParameterInfo[] parameters )
        {
            Parameters = parameters.OrderBy(x => x.Position).ToList();
        }

        public List<BUsing> GetUsings()
        {
            List<BUsing> usings = new List<BUsing>();
            foreach(var parameter in Parameters)
            {
                usings.Add(new BUsing(parameter.GetType()));
            }
            return usings;
        }
    }
}
