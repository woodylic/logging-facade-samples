using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;

namespace Common.Logging.Sample.Library
{
    public class SomeComponent
    {
        private static ILog _logger = LogManager.GetLogger(typeof(SomeComponent));

        public void DoSomething()
        {
            _logger.Info("Before executing ...");

            Console.WriteLine("Executing DoSomething");

            _logger.Info("After executing ...");
        }
    }
}
