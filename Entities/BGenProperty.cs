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

        }

        public override List<BUsing> GetUsings()
        {
            return PropType.GetGenericArguments().Select(x => new BUsing(x.Namespace)).Union(base.GetUsings()).ToList();
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
    }
}
