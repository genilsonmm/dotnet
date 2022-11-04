using Newtonsoft.Json;

namespace AppGitHub.Model
{
    internal class User
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string Avatar { get; set; }
    }
}
