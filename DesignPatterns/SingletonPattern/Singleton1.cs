using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //http://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
    public class Singleton1
    {
        private Singleton1()
        {

        }

        private static Singleton1 instance = null;
        public static Singleton1 Instance
        {
            get
            {

                if (instance == null)
                {
                    instance = new Singleton1();
                }

                return instance;
            }



        }
    }
}
