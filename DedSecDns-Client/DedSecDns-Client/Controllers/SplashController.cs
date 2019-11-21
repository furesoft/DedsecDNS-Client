using System;
using DedSecDns_Client.Core.MVC;

namespace DedSecDns_Client.Controllers
{
    public class SplashController : Controller
    {
        public override IView View => new SplashView();

        public override bool Loadable()
        {
            return true;
        }
    }
}