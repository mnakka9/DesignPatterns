using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class AdapterPetternClass
    {
        public void Main()
        {
            ITarget dub = new Adapter();

            dub.Request();
        }
    }

    public interface ITarget
    {
        void Request();
    }

    public class Adapter : ITarget
    {
        Adaptee adaptee = null;

        public void Request()
        {
            if(adaptee == null)
            {
                adaptee = new Adaptee();
            }

            adaptee.SpecificRequest();
        }
    }

    public class Adaptee
    {
        public string SpecificRequest()
        {
            return "Hi Bro's";
        }
    }
}
