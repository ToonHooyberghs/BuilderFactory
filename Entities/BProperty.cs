using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BProperty
    {
        public PropertyInfo PropInfo { get; protected set; }
        public Type PropType { get; protected set; }
        public string PropName { get; protected set; }
        public string PropNamespace { get; protected set; }
        public bool HasPublicSetter { get; protected set; }
        public bool IsGeneric { get; protected set; }
        public bool IsIList { get; protected set; }
        public int GenericArgumentsCounts { get; protected set; }

        public BProperty(PropertyInfo propertyInfo)
        {
            PropInfo = propertyInfo;
            PropType = propertyInfo.PropertyType;
            PropName = propertyInfo.Name;
            PropNamespace = PropType.Namespace;
            HasPublicSetter = (propertyInfo.GetSetMethod(true) != null) && (propertyInfo.GetSetMethod(true).IsPublic);
            IsIList = (typeof(IList).IsAssignableFrom(PropType));
            IsGeneric = false;
            GenericArgumentsCounts = 0;
        }

        public virtual List<BUsing> GetUsings()
        {
            return new List<BUsing>() { new BUsing(PropType.Namespace) };
        }

        public virtual List<BFindReplace> GetReplacements()
        {
            List<BFindReplace> replacements = new List<BFindReplace>();
            replacements.Add(new BFindReplace(BConstants.PropName, PropName));
            replacements.Add(new BFindReplace(BConstants.PropArg, GetArg(false)));
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
