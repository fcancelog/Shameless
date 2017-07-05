using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ShamelessMobile.Utils
{
    public static class JsonPrettifier
    {
        public static string FormatJson(string str)
        {
            var formatted = JArray.Parse(str).ToString(Formatting.Indented);
            return formatted;
        }
    }
}
