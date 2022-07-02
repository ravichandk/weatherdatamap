using System.Net.Http;

namespace Services.Impl
{
    public interface IHttpClientService
    {
        string FetchData(string url);
    }

    public class HttpClientService
    {
        public static string FetchData(string url)
        {
            string content = null;

            using (var httpClient = new HttpClient())
            {
                content = httpClient.GetAsync(url)
                     .Result
                     .Content
                     .ReadAsStringAsync()
                     .Result;
            }

            return content;
        }
    }

    public class FetchDataService<T>
    {

    }
}
