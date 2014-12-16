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
        }

        public string Namespace { get; set; }
        public Type Type { get; set; }
        public IList<BUsing> Usings { get; set; }
        public IList<BConstructor>  Constructors { get; set; }
        public IList<BProperty> Properties{ get; set; }

        public List<BUsing> GetUsings()
        {
            return Usings.ToList();
        }

        public List<BFindReplace> GetReplacements()
        {
            // public static string ClassTypeName = "{ClassTypeName}";
            //public static string ClassInstanceName = "{ClassInstanceName}";
            //    public static string ClassNamespace = "{ClassNamespace}";  

            List<BFindReplace> replacements = new List<BFindReplace>();
            replacements.Add(new BFindReplace(BConstants.ClassTypeName,"" ));
            replacements.Add(new BFindReplace(BConstants.ClassInstanceName, ""));
            

            return replacements;
        }        

    }
}
