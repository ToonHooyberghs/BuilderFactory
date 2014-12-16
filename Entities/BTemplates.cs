using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    [Serializable]
    public class BTemplates
    {
        
        public Collection<BTemplate> Templates = new Collection<BTemplate>();
    }
}
