using BuilderFactory;
using BuilderFactory.Entities;
using SDWORX.Rapportering.Essence.Domain.Web.Bewerkingen;
using SDWORX.Rapportering.Essence.Domain.Web.Parameters;
using SDWORX.Rapportering.Essence.Domain.Web.Rapportering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBench
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\GitHub\BuilderFactory\TestBench\Output.cs";
            File.WriteAllText(filePath, "");

            Factory factory = new Factory();
            factory.CreateBuilders(typeof(Rapport).Assembly);
            List<BResult> results = new List<BResult>();
            TemplateService templateService = new TemplateService();

            foreach (var builder in factory.Builders/*.Where(x => x.Type.Equals(typeof(FunctieRapportVeld)))*/)
            {
                BuilderComposer bComposer = new BuilderComposer(templateService);
                results.Add(bComposer.Compose(builder));              
            }

            var defaultUsings = templateService.GetTemplate(BConstants.TmplDefaultUsings).Split(new String[]{"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            
            string usings =  string.Join("\r\n", results.SelectMany(x => x.BClass.GetUsings()).Select(y => "using " +  y.Namespace.Trim() + ";").Union(defaultUsings.Select(x => "using " +  x.Trim() + ";")).Distinct().OrderBy(z => z.Length));
            string builderNamespace = "Entities.Builders";
            string classes = string.Join("\r\n", results.Select(x => x.Builder));
            string baseClass = templateService.GetTemplate(BConstants.TmplBaseClass);
            string file = templateService.GetTemplate(BConstants.TmplFile);
            
            List<BFindReplace> replacements = new List<BFindReplace>();
            replacements.Add(new BFindReplace(BConstants.ClassBaseClass, baseClass));
            replacements.Add(new BFindReplace(BConstants.ClassUsings,  usings ));
            replacements.Add(new BFindReplace(BConstants.BuilderNamespace, builderNamespace));
            replacements.Add(new BFindReplace(BConstants.ClassBody, classes ));
            
            file = ApplyReplacements(file, replacements);

            File.AppendAllText(filePath, file);

            Console.ReadKey();


        }

        private static string ApplyReplacements(string template, IEnumerable<BFindReplace> placeholders)
        {
            foreach (var placeholder in placeholders)
            {
                template = template.Replace(placeholder.Find, placeholder.Replace);
            }

            return template;
        }
    }
}
