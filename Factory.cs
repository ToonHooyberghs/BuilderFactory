using BuilderFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory
{
    public class Factory
    {
        public  IList<BClass> Builders = new List<BClass>();

        public Factory()
        {

        }

        public void CreateBuilders(Assembly assembly)
        {
            var allTypesToBuild = assembly.GetTypes().Where(x => x.IsClass && x.IsPublic && !x.IsAbstract && !x.Name.ToLower().Contains("builder"));

            foreach (var type in allTypesToBuild)
            {
                Builders.Add(CreateBuilder(type));              
            }

        }

        private BClass CreateBuilder(Type type)
        {
            string typeName = type.GetTypeInfo().Name;
            string typeNamespace = type.GetTypeInfo().Namespace;

            //GET Constructors
            var allConstructors = type.GetConstructors();

            //GET Properties
            var allProperties = type.GetProperties();

            BClassBuilder classBuilder = new BClassBuilder(type);

            //Add Constructors
            foreach(var constructor in allConstructors)
            {
                classBuilder.AddConstructor(new BConstructor(constructor.GetParameters()));
            }
            
            //Add Properties
            foreach(var property in allProperties)
            {
                if(property.PropertyType.IsGenericType == false)
                    classBuilder.AddProperty(new BProperty(property));
                else
                    classBuilder.AddProperty(new BGenProperty(property));
            }

            return classBuilder.Create();

        }

    }
}
