using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactory
{
    public interface IBuilder<T> where T : class
    {
        T Create();
    }

    public abstract partial class BaseBuilder<T, B> : IBuilder<T> where T : class
    {
        protected T Instance {get; set;}

        public T Create()
        {
            return Instance;
        }       
    }

    public class TestBuilder:BaseBuilder<Test,TestBuilder>
    {
        public TestBuilder Init( string a)
        {
            Instance = new Test();
            return this;
        }
    }

    public class Test
    {

    }
}
