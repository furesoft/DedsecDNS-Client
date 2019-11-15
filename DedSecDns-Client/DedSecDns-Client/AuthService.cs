using DedSecDns_Client.Core;
using DedSecDns_Client.Models;
using Newtonsoft.Json;
using RestSharp;
using System.IdentityModel.Tokens.Jwt;

namespace DedSecDns_Client
{
    public static class AuthService
    {
        public static bool Authenticate(string username, string password)
        {
            var client = new RestClient($"https://{DOMAIN}/oauth/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"grant_type=password&username={username}&password={password}&audience=http://dedsec-dns.api&client_id={CLIENT_ID}&client_secret={CLIENT_SECRET}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var result = JsonConvert.DeserializeObject<AuthResult>(response.Content);
                var parsed_token = new JwtSecurityTokenHandler();
                var token = parsed_token.ReadJwtToken(result.AccessToken);
                Session.Set("access_token", token);
                return true;
            }

            return false;
        }

        private const string CLIENT_ID = "5ed6BAqXgVVnRzxAXlei5Zlp1pRSEKQq";
        private const string CLIENT_SECRET = "cNaBFXkY1OJRQLoBgbdvJIgR6lE4peOxeK4m-zWgIjQB3puFdXw-g5FrnSkTjDyc";
        private const string DOMAIN = "furesoft.eu.auth0.com";
    }
}