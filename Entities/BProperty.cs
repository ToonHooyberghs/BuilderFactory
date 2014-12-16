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

        public List<BUsing> GetUsings()
        {
            if(IsGeneric)
            {
                return PropInfo.PropertyType.GetGenericArguments().Select(x => new BUsing(x.Namespace)).ToList();                
            }
            else
            {
                return new List<BUsing>();
            }
           
        }
    }
}
