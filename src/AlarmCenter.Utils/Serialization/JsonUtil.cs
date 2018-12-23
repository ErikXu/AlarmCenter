using Newtonsoft.Json;

namespace AlarmCenter.Utils.Serialization
{
    public interface IJsonUtil
    {
        T DeserializeObject<T>(string value);

        string SerializeObject(object value);
    }

    public class JsonUtil : IJsonUtil
    {
        public T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}