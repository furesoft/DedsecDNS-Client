using DedSecDns_Client.Core.MVC;
using DedSecDns_Client.Views;

namespace DedSecDns_Client.Controllers
{
    internal class MainViewController : Controller
    {
        public override IView View => new MainView();

        public override bool Loadable()
        {
            return true;
        }
    }
}