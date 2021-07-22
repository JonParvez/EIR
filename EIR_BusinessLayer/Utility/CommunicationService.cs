using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EIR_BusinessLayer.Utility
{
    public class CommunicationService
    {
        private static HttpClient Client = new HttpClient();

        public async Task<TOut> PostRequest<TIn, TOut>(string uri, TIn requestObject)
        {
            try
            {
                Client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                //var serialized = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
                var serialized = new StringContent(JsonSerializer.Serialize(requestObject), Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await Client.PostAsync(uri, serialized))
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    //return JsonConvert.DeserializeObject<TOut>(responseBody);
                    return JsonSerializer.Deserialize<TOut>(responseBody);
                }
            }
            catch (Exception ex)
            {
                return default(TOut);
            }
        }

        public async Task<T> GetRequest<T>(string uri)
        {
            try
            {
                Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response = await Client.GetAsync(uri))
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<T>(responseBody);
                }
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }

}
