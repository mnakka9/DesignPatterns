using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    public class ProxyPatternClass
    {
        public void Main()
        {
            MathProxy proxy = new MathProxy();
            Console.WriteLine(proxy.Add(new Int32[] { 1, 2, 3, 4, 5 }));
        }
    }

    public interface IMath
    {
        int Add(int[] arguments);
    }

    public class Math : IMath
    {
        public int Add(int[] arguments)
        {
            return arguments.Sum();
        }
    }

    public class MathProxy : IMath
    {
        private readonly Math mathObj = new Math();

        public MathProxy()
        {
            
        }
        public int Add(int[] arguments)
        {
            return mathObj.Add(arguments);
        }
    }
}
