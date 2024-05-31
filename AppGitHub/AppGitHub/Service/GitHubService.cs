using AppGitHub.Model;
using Newtonsoft.Json;


namespace AppGitHub.Service
{
    public class GitHubService
    {
        private readonly string url = "https://api.github.com/users";
        public async Task<List<User>> GetUsers()
        {
            var httpClient = new HttpClient();

            using var httpResponse = await httpClient.GetAsync(url);

            if (!httpResponse.IsSuccessStatusCode)
                throw new Exception("Algo deu errado!");

            string json = await httpResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<User>>(json);
        }
    }
}
