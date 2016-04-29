using Newtonsoft.Json;

namespace One.Common
{
    public class JsonHelper
    {
        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
