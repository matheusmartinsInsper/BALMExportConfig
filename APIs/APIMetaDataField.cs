using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Web;

namespace ExportConfigurationBALM.APIs
{
    public class APIMetaDataField
    {
        private readonly string _BaseUrl = "https://balm.cloud:8055/api/NewMetaDataType/Metadata?metadataTypeId=47";
        public async Task<List<JObject>> GET(int id,string token)
        {
            using (HttpClient client = new HttpClient())
            {
                UriBuilder uriBuilder = new UriBuilder(_BaseUrl);
                //uriBuilder.Query = $"metadataTypeId={id}";
                try
                {
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", token);
                    HttpResponseMessage response = await client.GetAsync(uriBuilder.Uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(responseBody);
                        List<JObject> mylist = json["data"].ToObject<List<JObject>>();
                        return mylist;
                    }
                    else
                    {
                        Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
