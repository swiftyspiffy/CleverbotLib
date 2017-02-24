using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverbotLib.Models
{
    public class Interaction
    {
        public string Input { get; protected set; }
        public string Output { get; protected set; }

        public Interaction(string input, string output)
        {
            Input = input;
            Output = output;
        }
    }
}
