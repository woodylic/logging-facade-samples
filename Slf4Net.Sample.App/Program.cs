using Slf4Net.Sample.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slf4Net.Sample.App
{
    class Program
    {
        static void Main(string[] args)
        {
            new SomeComponent().DoSomething();

            Console.ReadKey();
        }
    }
}
