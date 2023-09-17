using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YANAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("hello world");
            Console.Out.WriteLine("what is your name?");
            String name = Console.In.ReadLine();
            Console.Out.WriteLine("Ok. " + name);
            Console.In.Read();
        }
    }
}
