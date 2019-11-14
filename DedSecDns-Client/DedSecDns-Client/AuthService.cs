using DedSecDns_Client.Models;
using Newtonsoft.Json;
using RestSharp;

namespace DedSecDns_Client
{
    public static class AuthService
    {
        public static bool Authenticate(string username, string password)
        {
            var client = new RestClient("https://furesoft.eu.auth0.com/oauth/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"grant_type=password&username={username}&password={password}&audience=http://dedsec-dns.api&client_id=5ed6BAqXgVVnRzxAXlei5Zlp1pRSEKQq&client_secret=cNaBFXkY1OJRQLoBgbdvJIgR6lE4peOxeK4m-zWgIjQB3puFdXw-g5FrnSkTjDyc", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var result = JsonConvert.DeserializeObject<AuthResult>(response.Content);
                Session.Set("access_token", result.AccessToken);
            }

            return false;
        }

        public static bool Register(string username, string password, string email)
        {
            return false;
        }

        public static void ResetPassword(string email)
        {
        }
    }
}