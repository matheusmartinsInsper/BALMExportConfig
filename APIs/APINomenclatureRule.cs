using Newtonsoft.Json.Linq;

namespace ExportConfigurationBALM.APIs
{
    public class APINomenclatureRule
    {
        private readonly string _BaseUrl = "https://balm.cloud:8055/api/nomenclature/all?page=0&pageSize=10&orderby=NomenclatureName&orderdir=asc";
        public async Task<List<JObject>> GET(string token)
        {
            using (HttpClient client = new HttpClient())
            {
                UriBuilder uriBuilder = new UriBuilder(_BaseUrl);
                try
                {
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", token);
                    HttpResponseMessage response = await client.GetAsync(uriBuilder.Uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseBody);
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
