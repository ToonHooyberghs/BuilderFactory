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

        public List<BFindReplace> GetReplacements()
        {
            List<BFindReplace> replacements = new List<BFindReplace>();
            replacements.Add(new BFindReplace(BConstants.CstrArgs, GetArgs(false)));
            replacements.Add(new BFindReplace(BConstants.CstrTypedArgs, GetArgs()));
            return replacements;
        }

        private string GetArgs(bool typed = true)
        {
            List<string> listArgs = new List<string>();

            foreach(var parameter in Parameters)
            {
                if(typed)
                    listArgs.Add(String.Format("{0} {1}",parameter.ParameterType.Name , parameter.Name));                
                else
                    listArgs.Add(String.Format("{0}", parameter.Name));                
            }

            return String.Join(" , ", listArgs);

        }
    }
}
