using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverbotLib
{
    public static class Core
    {
        public static Models.CleverbotResponse Talk(string message, string state = null)
        {
            string jsonStr = Common.ApiCall(message, state);
            if (jsonStr == null)
                return null;
            JToken resp = JObject.Parse(jsonStr);
            return new Models.CleverbotResponse(resp);
        }

        public static Models.CleverbotResponse Talk(string message, Models.CleverbotResponse previousResponse = null)
        {
            string force = null;
            if (previousResponse != null)
                return Talk(message, previousResponse.CleverbotState);
            else
                return Talk(message, force);
        }

        public static void SetAPIKey(string apiKey)
        {
            Common.apiKey = apiKey;
        }
    }
}
