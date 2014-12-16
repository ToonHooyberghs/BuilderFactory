using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BuilderFactory.Entities
{
    public class TemplateService
    {
        Dictionary<string, string> templates = new Dictionary<string, string>();

        public TemplateService()
        {
            //XmlDocument doc = new XmlDocument();
            //XmlTextReader reader = new XmlTextReader(@"C:\GitHub\BuilderFactory\BuilderTemplates.xml");
            //reader.Read();            
            //doc.Load(reader);
            //reader.Close();

            BTemplates introToVCS = new BTemplates();
            System.Xml.Serialization.XmlSerializer reader = new
            System.Xml.Serialization.XmlSerializer(introToVCS.GetType());

            // Read the XML file.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\GitHub\BuilderFactory\BuilderTemplates.xml");

            // Deserialize the content of the file into a Book object.
            introToVCS = (BTemplates)reader.Deserialize(file);

            foreach(var template in introToVCS.Templates)
            {
                templates.Add(template.Key,template.Value);
            }

            

        }

        public string GetTemplate( string key)
        {
            return templates[key];
        }
    }
}
