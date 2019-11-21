using DedSecDns_Client.Core.MVC;
using DedSecDns_Client.Views;

namespace DedSecDns_Client.Controllers
{
    internal class LoginViewController : Controller
    {
        public override IView View => new LoginView();

        public override bool Loadable()
        {
            return true;
        }
    }
}