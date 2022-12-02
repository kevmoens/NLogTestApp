using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogTestApp
{
    class Addition : IMath
    {
        public string InputA { get; set; }
        public string InputB { get; set; }
        public string Output { get; set; }
        private NLog.Logger _logger;
        public Addition()
        {
            _logger = NLog.LogManager.GetCurrentClassLogger();
        }
        public void PromptUser()
        {
            Console.Clear();
            Console.WriteLine("Addition");
            Console.WriteLine("Enter Input A");
            InputA = Console.ReadLine();
            Console.WriteLine("Enter Input B");
            InputB = Console.ReadLine();
        }
        public void Calculate()
        {
            _logger.Info("Calculate Start");
            decimal a = 0;
            decimal b = 0;
            if (decimal.TryParse(InputA, out a) == false)
            {
                _logger.Error("Calculate Unable to parse InputA");
                Output = "Unable to parse InputA";
                return;
            }
            if (decimal.TryParse(InputB, out b) == false)
            {
                _logger.Error("Calculate Unable to parse InputB");
                Output = "Unable to parse InputB";
                return;
            }
            Output = (a + b).ToString();
            _logger.Info("Calculate End Output {Output}", Output);
        }
    }
}
