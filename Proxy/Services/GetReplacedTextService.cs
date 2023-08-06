namespace Proxy.Services
{
    public class GetReplacedTextService
    {
        public async Task<string> GetResponseFromUrl(string url)
        {
            string res;

            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    res = apiResponse;
                }
            }
            return res;
        }
    }
}
