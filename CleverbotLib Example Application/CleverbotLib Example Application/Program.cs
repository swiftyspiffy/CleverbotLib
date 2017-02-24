using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverbotLib_Example_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CleverbotLib Example Application");

            Console.WriteLine("Insert your API key:");
            CleverbotLib.Core.SetAPIKey(Console.ReadLine());

            Console.WriteLine("Now begin your conversation!");

            CleverbotLib.Models.CleverbotResponse resp = null;
            while (true)
            {
                Console.Write("You: ");
                if (resp == null)
                    resp = CleverbotLib.Core.Talk(Console.ReadLine());
                else
                    resp = CleverbotLib.Core.Talk(Console.ReadLine(), resp);
                Console.WriteLine($"Cleverbot: {resp.Output}");
            }
        }
    }
}
