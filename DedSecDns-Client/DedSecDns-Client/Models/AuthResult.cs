namespace DedSecDns_Client.Models
{
    internal class AuthResult
    {
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}