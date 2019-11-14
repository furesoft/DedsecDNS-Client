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
            request.AddParameter("application/x-www-form-urlencoded", "grant_type=password&username={username}&password={password}&audience=YOUR_API_IDENTIFIER&scope=read%3Asample&client_id=%24%7Baccount.clientId%7D&client_secret=YOUR_CLIENT_SECRET", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public static bool Register(string username, string password, string email)
        {
        }

        public static void ResetPassword(string email)
        {
        }
    }
}