using BuilderFactory;
using BuilderFactory.Entities;
using SDWORX.Rapportering.Essence.Domain.Web.Rapportering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBench
{
    class Program
    {
        static void Main(string[] args)
        {          


            Factory factory = new Factory();
            factory.CreateBuilders(typeof(Rapport).Assembly);

            foreach(var builder in factory.Builders)
            {
                BuilderComposer bComposer = new BuilderComposer(builder, new TemplateService());
                BResult result = bComposer.Compose();
                
            }

            Console.ReadKey();


        }
    }
}
