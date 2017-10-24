using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class SingletonLazy
    {
        private SingletonLazy()
        {

        }

        private static readonly Lazy<SingletonLazy> lazyInstance =
            new Lazy<SingletonLazy>(() => new SingletonLazy());

        public SingletonLazy Instance
        {
            get
            {

                return lazyInstance.Value;
            }
        }
    }
}
