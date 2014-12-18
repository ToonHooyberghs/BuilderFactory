using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BGenProperty : BProperty
    {    
        public BGenProperty(PropertyInfo propertyInfo):base(propertyInfo)
        {
            IsGeneric = PropType.IsGenericType;
            GenericArgumentsCounts = PropType.GetGenericArguments().Count();
        }

        public override List<BUsing> GetUsings()
        {
            return PropType.GetGenericArguments().Select(x => new BUsing(x.Namespace)).Union(base.GetUsings()).ToList();
        }

        public override List<BFindReplace> GetReplacements()
        {

            List<BFindReplace> replacements = new List<BFindReplace>();            
            replacements.Add(new BFindReplace(BConstants.GenPropArg1, GetGenArg(false)));
            replacements.Add(new BFindReplace(BConstants.GenPropTypedArg1, GetGenArg()));

            return replacements.Union(base.GetReplacements()).ToList();
        }

        protected override string GetPropTypeName()
        {
            var genericType = PropType.GetGenericTypeDefinition().Name;
            var genericArgs = PropType.GetGenericArguments().Select(x => x.Name);
            string genericFinalType = String.Empty;

            string numberToReplace = string.Format("`{0}", genericArgs.Count());
                       
            genericFinalType = genericType.Replace(numberToReplace, "<" +  string.Join("," ,  genericArgs) + ">");
           
            return genericFinalType;
        }

        private string GetGenArg(bool typed = true)
        {
            if (typed)
                return (String.Format("{0} {1}", PropType.GetGenericArguments().First().Name, "value"));
            else
                return (String.Format("{0}", "value"));
        }
    }
}
