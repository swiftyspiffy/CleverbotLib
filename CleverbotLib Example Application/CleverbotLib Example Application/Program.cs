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
            string apiKey = Console.ReadLine();
            CleverbotLib.Core.SetAPIKey(apiKey);
            Console.WriteLine("Now begin your conversation!");
            CleverbotLib.Models.CleverbotResponse resp = null;
            while(true)
            {
                Console.Write("You: ");
                string myMessage = Console.ReadLine();
                string force = null;
                if (resp == null)
                    resp = CleverbotLib.Core.Talk(myMessage, force);
                else
                    resp = CleverbotLib.Core.Talk(myMessage, resp);
                Console.WriteLine($"Cleverbot: {resp.Output}");
            }
        }
    }
}
