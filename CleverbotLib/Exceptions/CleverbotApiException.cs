using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverbotLib.Exceptions
{
    public class CleverbotApiException : Exception
    {
        public CleverbotApiException(string errorDetails)
            : base($"An exception has occured with Cleverbot's API. Please view the details: {errorDetails}")
        {
        }
    }
}
