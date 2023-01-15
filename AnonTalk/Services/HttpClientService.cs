using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace AnonTalk.Services
{
    public class HttpClientService : IHttpClientService
    {
        private static HttpClient client = new HttpClient();
        public HttpClientService()
        {
            client.BaseAddress = new Uri(AppSettings.Api.BaseUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<T> Get<T>(string uri) where T : class
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
                T dto = await JsonSerializer.DeserializeAsync<T>(await response.Content.ReadAsStreamAsync(), options);
                return dto;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool> Post<T>(T body, string uri) where T : class
        {
            try
            {
                var jsonBody = JsonSerializer.Serialize(body);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(uri, content);
                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
