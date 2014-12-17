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

       // public Dictionary<string, string> Placeholders = new Dictionary<string, string>();
        
        public BuilderComposer( TemplateService templateService)
        {
            //BClass = bClass;
            TemplateService = templateService;
        }

        public BResult Compose(BClass bClass , bool seperateFile = false)
        {  
            string constructors = ComposeConstructors(bClass);
            string properties = ComposeProperties(bClass);

            List<BFindReplace> replacements = new List<BFindReplace>();
            replacements.Add(new BFindReplace(BConstants.ClassConstructors, constructors));
            replacements.Add(new BFindReplace(BConstants.ClassProperties, properties));

            string tmplClass = ComposeClass(bClass);
            tmplClass = ApplyReplacements(tmplClass, replacements.Union(bClass.GetReplacements()));
            
            return new BResult(bClass, tmplClass); 
        }

        private string ComposeClass(BClass bClass)
        {
            StringBuilder sBuilder = new StringBuilder();

            string tmplClass = TemplateService.GetTemplate(BConstants.TmplClass);
            tmplClass = ApplyReplacements(tmplClass, bClass.GetReplacements());
            sBuilder.AppendLine(tmplClass);

            return sBuilder.ToString();
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
                sBuilder.AppendLine(ComposeConstructor(constructor));               
            }

            return sBuilder.ToString();
        }

        public string ComposeProperties(BClass bClass)
        {
            StringBuilder sBuilder = new StringBuilder();

            foreach (var property in bClass.Properties)
            {
                sBuilder.AppendLine(ComposeProperty(property));               
            }

            return sBuilder.ToString();
        }

        private string ComposeConstructor(BConstructor bConstructor)
        {
            StringBuilder sBuilder = new StringBuilder();
            
            string tmplConstructor = TemplateService.GetTemplate(BConstants.TmplConstructor);
            tmplConstructor = ApplyReplacements(tmplConstructor, bConstructor.GetReplacements());
            sBuilder.AppendLine(tmplConstructor);

            return sBuilder.ToString();
        }

        private string ComposeProperty(BProperty bProperty)
        {
            StringBuilder sBuilder = new StringBuilder();

            string tmplProperty = TemplateService.GetTemplate(BConstants.TmplProperty);
            tmplProperty = ApplyReplacements(tmplProperty, bProperty.GetReplacements());
            sBuilder.AppendLine(tmplProperty);

            return sBuilder.ToString();
        }

        private string ComposeSimpelProperty(BProperty bProperty)
        {
            return null;
        }

        private string ComposeGenericProperty(BProperty bProperty)
        {
            return null;
        }
        
        private string ApplyReplacements(string template, IEnumerable<BFindReplace> placeholders)
        {
            foreach(var placeholder in placeholders)
            {
                template = template.Replace(placeholder.Find, placeholder.Replace);
            }

            return template;
        }
    }
}
