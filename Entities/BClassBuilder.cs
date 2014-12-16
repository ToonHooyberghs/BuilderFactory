using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BClassBuilder
    {
        private BClass _BClass;

        public BClass Create()
        {
            return _BClass;
        }

        public static BClassBuilder Init(Type type)
        {
            return new BClassBuilder(type);
        }

        public BClassBuilder(Type type)
        {
            _BClass = new BClass(type);
        }

        public static implicit operator BClass(BClassBuilder builder)
        {
            return builder.Create();
        }

        public BClassBuilder Namespace(string value)
        {
            _BClass.Namespace = value;
            return this;
        }

        public BClassBuilder AddUsing(BUsing value)
        {
            _BClass.Usings.Add(value);           
            return this;
        }

        public BClassBuilder AddUsings(Collection<BUsing> values)
        {
            foreach (BUsing bUsing in values)
            {
                AddUsing(bUsing);
            }
            return this;
        }

        public BClassBuilder AddConstructor(BConstructor value)
        {
            _BClass.Constructors.Add(value);            
            return this;
        }

        public BClassBuilder AddConstructors(Collection<BConstructor> values)
        {
            foreach (BConstructor bConstructor in values)
            {
                AddConstructor(bConstructor);
            }
            return this;
        }

        public BClassBuilder AddProperty(BProperty value)
        {           
            _BClass.Properties.Add(value);            
            return this;
        }

        public BClassBuilder AddProperties(Collection<BProperty> values)
        {
            foreach (BProperty bProperty in values)
            {
                AddProperty(bProperty);
            }
            return this;
        }

    }
    
}
