using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory.Entities
{
    public class BConstants
    {
        
        //Templates
        public static string TmplFile = "File";
        public static string TmplClass = "Class";
        public static string TmplConstructor = "Constructor";
        public static string TmplProperty = "Property";


        //Class
        public static string ClassTypeName = "{ClassTypeName}";
        public static string ClassInstanceName = "{ClassInstanceName}";
        public static string ClassNamespace = "{ClassNamespace}";        
        public static string ClassUsings = "{ClassUsings}";
        public static string ClassBody = "{ClassBody}";
        public static string ClassConstructors = "{ClassConstructors}";
        public static string ClassProperties = "{ClassProperties}";

        //BuilderClass
        public static string BuilderTypeName = "{BuilderTypeName}";
        public static string BuilderNamespace = "{BuilderNamespace}";
        //Property
        public static string PropName = "{PropName}";        
        public static string PropArg = "{PropArg}";
        public static string PropTypedArg = "{PropTypedArg}";
        //Constructor
        public static string CstrArgs = "{CstrArgs}";
        public static string CstrTypedArgs = "{CstrTypedArgs}";
        

    }

    
}
