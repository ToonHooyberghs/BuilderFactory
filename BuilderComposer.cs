using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BuilderComposer
    {
        public BClass BClass { get; private set; }
        public TemplateService TemplateService { get; private set; }

        public Dictionary<string, string> Placeholders = new Dictionary<string, string>();
        
        public BuilderComposer(BClass bClass , TemplateService templateService)
        {
            BClass = bClass;
            TemplateService = templateService;
        }

        public BResult Compose()
        {
            StringBuilder sBuilder = new StringBuilder();
                        
            //Placeholders.Add(BConstants.ClassConstructors,  ComposeConstructors(BClass).ToString());
            //Placeholders.Add(BConstants.ClassProperties, ComposeProperties(BClass).ToString());

            sBuilder.AppendLine(ComposeClass(BClass).ToString());
            
             string result = sBuilder.ToString();

            foreach(var res in Placeholders)
            {
                result = result.Replace(res.Key, res.Value);
            }

            return new BResult(BClass, "");

        }

        private StringBuilder ComposeClass(BClass bClass)
        {
            StringBuilder sBuilder = new StringBuilder();

            string classTemplate = TemplateService.GetTemplate(BConstants.TmplClass);
            sBuilder.AppendLine(classTemplate);

            return sBuilder;
        }

        //private StringBuilder ComposeUsings(BClass bClass)
        //{
        //    StringBuilder sBuilder = new StringBuilder();

        //    foreach(var bUsing in bClass.Usings)
        //    {
        //        sBuilder.AppendLine("using " + bUsing.Namespace + ";");
        //    }

        //    foreach (var bUsing in bClass.Constructors.SelectMany( x => x.GetUsings()))
        //    {
        //        sBuilder.AppendLine("using " + bUsing.Namespace + ";");
        //    }

        //    foreach (var bUsing in bClass.Properties.SelectMany(x => x.GetUsings()))
        //    {
        //        sBuilder.AppendLine("using " + bUsing.Namespace + ";");
        //    }

        //    return sBuilder;          
        //}
        
        public string ComposeConstructors(BClass bClass)
        {
            StringBuilder sBuilder = new StringBuilder();

            foreach(var constructor in bClass.Constructors)
            {
                sBuilder.AppendLine(ComposeConstructor(constructor).ToString());
            }

            return sBuilder.ToString();
        }

        public string ComposeProperties(BClass bClass)
        {
            StringBuilder sBuilder = new StringBuilder();

            foreach (var property in bClass.Properties)
            {
                sBuilder.AppendLine(ComposeProperty(property).ToString());
            }

            return sBuilder.ToString();
        }

        private StringBuilder ComposeConstructor(BConstructor bConstructor)
        {
            StringBuilder sBuilder = new StringBuilder();

            string tmplConstructor = TemplateService.GetTemplate(BConstants.TmplConstructor);
            sBuilder.AppendLine(tmplConstructor);

            return sBuilder;    
        }

        private StringBuilder ComposeProperty(BProperty bProperty)
        {
            StringBuilder sBuilder = new StringBuilder();

            string tmplProperty = TemplateService.GetTemplate(BConstants.TmplProperty);
            sBuilder.AppendLine(tmplProperty);

            return sBuilder;  
        }

        private StringBuilder ComposeSimpelProperty(BProperty bProperty)
        {
            return null;
        }

        private StringBuilder ComposeGenericProperty(BProperty bProperty)
        {
            return null;
        }
    }
}
