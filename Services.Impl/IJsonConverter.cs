using Models;
using Newtonsoft.Json;

namespace Services.Impl
{
    public interface IJsonConverter<T>
    {
        T ConvertToModel(string json);
    }

    public abstract class AbstractJsonConverter<T> : IJsonConverter<T>
    {
        public virtual T ConvertToModel(string json)
        {
            var model = JsonConvert.DeserializeObject<T>(json);
            return model;
        }
}

    public class WeatherDataConverter : AbstractJsonConverter<WeatherData>
    {

    }
}
