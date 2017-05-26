using slf4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slf4Net.Sample.Library
{
    public class SomeComponent
    {
        private static ILogger _logger = LoggerFactory.GetLogger(typeof(SomeComponent));

        public void DoSomething()
        {
            _logger.Info("Before executing ...");

            Console.WriteLine("Executing DoSomething");

            _logger.Info("After executing ...");
        }
    }
}
