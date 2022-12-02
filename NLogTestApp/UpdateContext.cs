using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogTestApp
{
    class UpdateContext : IMath
    {
        public string Output { get; set; }

        public void PromptUser()
        {
            Console.WriteLine("Update Context");
            Console.WriteLine("Enter Context Value");
            NLog.MappedDiagnosticsContext.Set("MyContext", Console.ReadLine());
        }

        public void Calculate()
        {
            
        }
    }
}
