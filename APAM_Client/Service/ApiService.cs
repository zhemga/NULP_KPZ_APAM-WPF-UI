using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAM_Client.Service
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using APAM_Client.DataModels.AutoPartSystem;
    using Newtonsoft.Json;

    public static class ApiService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<T> SendRequest<T>(string endpoint, HttpMethod method, object content = null)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(endpoint),
                Method = method,
            };

            if (content != null)
            {
                var jsonContent = JsonConvert.SerializeObject(content);
                request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            }

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return default(T);
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var serializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include };

            return JsonConvert.DeserializeObject<T>(responseContent, serializerSettings);
        }
    }
}
