using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BProperty
    {
        public PropertyInfo PropInfo { get; private set; }
        public Type PropType { get; private set; }
        public string PropName {get; private set;}
        public string PropNamespace {get; private set;}
        public bool HasPublicSetter {get;private set;}
        public bool IsGeneric { get; private set; }

        public BProperty(PropertyInfo propertyInfo)
        {
            PropInfo = propertyInfo;
            PropType = propertyInfo.PropertyType;
            PropName = PropType.Name;
            PropNamespace = PropType.Namespace;
            HasPublicSetter = (propertyInfo.GetSetMethod(true) != null) && (propertyInfo.GetSetMethod(true).IsPublic);
            IsGeneric = PropType.IsGenericType;
        }

        public virtual List<BUsing> GetUsings()
        {
            return new List<BUsing>() { new BUsing(PropType.Namespace) };
        }

        public List<BFindReplace> GetReplacements()
        {
            List<BFindReplace> replacements = new List<BFindReplace>();
            replacements.Add(new BFindReplace(BConstants.PropName, PropName));
            replacements.Add(new BFindReplace(BConstants.PropArg, GetArg()));
            replacements.Add(new BFindReplace(BConstants.PropTypedArg, GetArg()));   
            return replacements;
        }

        protected virtual string GetPropTypeName()
        {
            return PropType.Name;
        }

        private string GetArg(bool typed = true)
        {           
                if (typed)
                   return (String.Format("{0} {1}", GetPropTypeName(), "value"));
                else
                    return (String.Format("{0}", "value"));    
        }

    }
}
