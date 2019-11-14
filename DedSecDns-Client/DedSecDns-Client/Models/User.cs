namespace DedSecDns_Client.Models
{
    public class User
    {
        public string email { get; set; }

        public bool includeEmailInRedirect { get; set; }
        public bool mark_email_as_verified { get; set; }
    }
}