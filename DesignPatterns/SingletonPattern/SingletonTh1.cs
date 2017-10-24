using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class SingletonTh1
    {
        private SingletonTh1()
        {

        }
        private static SingletonTh1 instance = null;
        private static readonly object lockObject = new object();
        public static SingletonTh1 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonTh1();
                        }


                    }

                }
                return instance;

            }



        }
    }
}
