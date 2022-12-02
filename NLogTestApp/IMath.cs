using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogTestApp
{
    interface IMath
    {
        void PromptUser();
        void Calculate();
        string Output { get; set; }
    }
}
