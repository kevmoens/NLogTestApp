using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogTestApp
{
    class ClearContext : IMath
    {
        public string Output { get; set; }

        public void Calculate()
        {
            NLog.MappedDiagnosticsContext.Remove("MyContext");
        }

        public void PromptUser()
        {

        }
    }
}
