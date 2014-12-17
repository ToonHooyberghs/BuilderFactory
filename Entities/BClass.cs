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
        public BClass(Type type)
        {
            Usings = new List<BUsing>();
            Constructors = new List<BConstructor>();
            Properties = new List<BProperty>();
            Type = type;
        }

        public string Namespace { get; set; }
        public Type Type { get; set; }
        public IList<BUsing> Usings { get; set; }
        public IList<BConstructor>  Constructors { get; set; }
        public IList<BProperty> Properties{ get; set; }

        public List<BUsing> GetUsings()
        {
            List<BUsing> allUsings = new List<BUsing>();
            allUsings.AddRange(Usings);
            allUsings.Add(new BUsing(Type.Namespace));
            allUsings.AddRange(Constructors.SelectMany(x => x.GetUsings()));
            allUsings.AddRange(Properties.SelectMany(x => x.GetUsings()));

            return allUsings;

        }

        public List<BFindReplace> GetReplacements()
        {          
            List<BFindReplace> replacements = new List<BFindReplace>();
            replacements.Add(new BFindReplace(BConstants.BuilderTypeName, Type.Name + "Builder"));
            replacements.Add(new BFindReplace(BConstants.ClassTypeName, Type.Name ));
            replacements.Add(new BFindReplace(BConstants.ClassInstanceName, "_" + Type.Name.ToLower()));  
            return replacements;
        }        

    }
}
