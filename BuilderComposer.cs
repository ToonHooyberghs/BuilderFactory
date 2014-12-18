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
        
        public BuilderComposer( TemplateService templateService)
        {           
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

            //TODO Had Private Setter Logic
            foreach (var property in bClass.Properties.Where(x => x.HasPublicSetter))
            {
                sBuilder.AppendLine(ComposeProperty(property));               
            }

            foreach (var property in bClass.Properties.Where(x => x.IsIList))
            {
                sBuilder.AppendLine(ComposeNoSetterEnumerableProperty(property));
            }

            foreach (var property in bClass.Properties.Where(x => x.IsIList && x.IsGeneric && x.GenericArgumentsCounts == 1))
            {
                sBuilder.AppendLine(ComposeNoSetterSingleEnumerableProperty(property));
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

        private string ComposeNoSetterEnumerableProperty(BProperty bProperty)
        {
            StringBuilder sBuilder = new StringBuilder();

            string tmplProperty = TemplateService.GetTemplate(BConstants.TmplNoSetterEnumerableProperty);
            tmplProperty = ApplyReplacements(tmplProperty, bProperty.GetReplacements());
            sBuilder.AppendLine(tmplProperty);

            return sBuilder.ToString();
        }

        private string ComposeNoSetterSingleEnumerableProperty(BProperty bProperty)
        {
            StringBuilder sBuilder = new StringBuilder();

            string tmplProperty = TemplateService.GetTemplate(BConstants.TmplNoSetterSinlgeEnumerableProperty);
            tmplProperty = ApplyReplacements(tmplProperty, bProperty.GetReplacements());
            sBuilder.AppendLine(tmplProperty);

            return sBuilder.ToString();
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
