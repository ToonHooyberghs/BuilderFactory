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
        
        public BuilderComposer(BClass bClass , TemplateService templateService)
        {
            BClass = bClass;
            TemplateService = templateService;
        }

        public string Compose()
        {
            StringBuilder sBuilder = new StringBuilder();

             string classTemplate = TemplateService.GetTemplate(BConstants.TmplClass);
             sBuilder.AppendLine(classTemplate);

            return sBuilder.ToString();

        }

        private StringBuilder ComposeUsings(BClass bClass)
        {
            StringBuilder sBuilder = new StringBuilder();

            foreach(var bUsing in bClass.Usings)
            {
                sBuilder.AppendLine("using " + bUsing.Namespace + ";");
            }

            return sBuilder;          
        }
        
        private StringBuilder ComposeConstructor(BConstructor bConstructor)
        {
            StringBuilder sBuilder = new StringBuilder();

            

            return sBuilder;    
        }

        private StringBuilder ComposeProperty(BProperty bProperty)
        {
            return null;
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
