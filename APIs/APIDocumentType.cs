using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace ExportConfigurationBALM.APIs
{
    public class APIDocumentType
    {
        private readonly string _BaseUrl= "https://balm.cloud:8055/api/metadatatype/ById?id=47";
        public async Task<JObject> GET(int id,string token)
        {
            //byte[] bytesToken = System.Text.Encoding.UTF8.GetBytes(token);

            // Convertendo os bytes para Base64
            //string tokenBase64 = Convert.ToBase64String(bytesToken);
            //string tokenEncoded = HttpUtility.UrlEncode(token);
            using (HttpClient client = new HttpClient())
            {
                UriBuilder uriBuilder = new UriBuilder(_BaseUrl);
                //uriBuilder.Query = $"id={id}";
                try
                {
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", token);
                    // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "x27XrUtmIorhLHTkflF//Q5AJex4dqHaKS0eatD1dmrM4By8e/P/UP0XGAZ+FSUdaXxp7fXJFMa6UIwkeoMYF61/muJaBrVYHSfnL2KV3GcqXaiUuDRRO/dO6SHeq0N9iXlvTVQATgTclRtr06/0e5SpH1ndJgDAdWuXixOJ4A818eX3FekbbGKpjZsVvnS0lZkDs7Suw6yYnx5nCYRqpg/alJCTpCGEtMMjUAAuLuIqDCCxUMOFXGtk3WkGEAY4H1ehbGZEbF0/xDy0T0lIDKqeQxGK9aHi33/oPTz7/ooLKqnaHB3k8zr+GaTYrdTIA9hJYTu3tx2zxV9RV5XtFnjZ0R/M49O8ZpZky3JpQdDVGfN2vgsHDO+aiNM+NWS+Rj1CzVz9I5YqSbNiTZhQB47kckQgiS8cxoj7XU0ielIlK4dzmpm5R8CqBzBD/TV03KhabINMmEmjXhnCD29xOidLA0+/7UGCZ23Ogu2Dc5OaKL6jANeytEDquFUcNjvZeGQJXz3U0CH3rSnmOpxK5GA95bxLtmKAe0LtENvQJnUtre9XKGXmhlrnjqmRb26BFgrNe95EJInlYITjtgXqMNuMHtI5zC5tOHrolqH291aRCWb0Grcrk2SWkk8O3ou1+dVdTwIWeY1zsnmAyrqSv8QOhT17uleu3pkd8mfFDsqc4Ika2uy3DAGTmOH0vTFb1D+4ufq++4ISeZwwt9uM1l7wdXrwCR1IGmhJ+N7CD2uaYwrqB2N5/ZcfxjOHHvyj");
                    HttpResponseMessage response = await client.GetAsync(uriBuilder.Uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return JObject.Parse(JObject.Parse(responseBody)["data"].ToString());
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
