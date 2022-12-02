using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = "";
            while (selection != "5")
            {
                Console.Clear();
                Console.WriteLine("Enter Selection");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Update Context");
                Console.WriteLine("4. Clear Context");
                Console.WriteLine("5. Quit/Exit");
                selection = Console.ReadKey().KeyChar.ToString();
                IMath math = null;
                switch (selection)
                {
                    case "1":
                        math = new Addition();
                        break;
                    case "2":
                        math = new Subtraction();
                        break;
                    case "3":
                        math = new UpdateContext();
                        break;
                    case "4":
                        math = new ClearContext();
                        break;
                }
                if (math != null)
                {
                    math.PromptUser();
                    math.Calculate();
                    if (string.IsNullOrWhiteSpace(math.Output))
                    {
                        continue;
                    }
                    Console.WriteLine(math.Output);                    
                    Console.ReadKey();
                }
            }
        }
    }
}
