using DedSecDns_Client.Core.MVC;
using DedSecDns_Client.Views;

namespace DedSecDns_Client.Controllers
{
    internal class ForgotPasswordController : Controller
    {
        public override IView View => _view ?? new ForgotPasswordView();

        public override bool Loadable()
        {
            return true;
        }

        private IView _view;
    }
}