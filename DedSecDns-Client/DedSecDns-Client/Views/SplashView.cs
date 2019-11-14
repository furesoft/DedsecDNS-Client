using DedSecDns_Client.Controllers;
using DedSecDns_Client.Core.MVC;
using nUpdate.Updating;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedSecDns_Client
{
    public partial class SplashView : Form, IView
    {
        public Form Form => this;

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        public SplashView()
        {
            InitializeComponent();
        }

        private async void SplashView_Load(object sender, EventArgs e)
        {
            xuiSplashScreen1.initializeLoader(this);

            var manager = new UpdateManager(new Uri("http://furesoft.ml/updates/dns-client/updates.json"), "<RSAKeyValue><Modulus>6TWTaOx+6MebUYg4MYPtpj0iN/6+0KP7RdQXaWyhjaHV4p71q2+Qk6NenyRydqy1bxakdma8WahyBS6D25lEo6Lro+pKXea7jtF3mglVKzoRqB6InHQCxC2kFSAm9tlDAwxxU0T9ZtgUM4zm35czzV9RwNutU+ShWjW0xqKCep6VRMM/JE179HnTmMpgfD0ZnbjPMHMrhtMY0Um1Sx+kXHUHcwe2eQfIGanpvDSXI/Cti4ztVrGXPtyDSHrGiMJz/Ay0GzkcYzQgsTCXDI/f73fh/4mNRRD/A+8L+XyCDufq2iWHNspDXKa3it5r69Vdh/kRI/irvOcx6tmukmW+SDBmCpqOmGFITwcTN88qLH07z7MpLbWXOA9V+fti/P6Pqg9qwWdDu8O5fxG0C+VCVK304JLhNOO5MeYiYkAj1yz5tRrY9qDUZ8sAAdk8UGnCscPaMyWEF6CTXClJQlhL/NbZ6U9PgM8W+tKpQ6KvEJi2DcR1mLAy3c29MBlkrPtBnHpZt30JVZzwXJDBMBR476wWiDWrPOan2zTa291NAfLHTff2HGC/HiPoAEtymtNdNQ3fJSPtU2T437PiS5ykchYIBJfvh18jvYX44CDKtImrTheByq0rUvDvgI9EXRJriZaU0g6cQ3vXWVtnpirk6ST7ZPw/biEq1oLWUmXlP9ZwzV5dm41oRIF7VN7rXSS3wEimHcu7147ocCKOxXm4+gS0kZhAYakrhJQLoXR8N1BEWdaJM+mtcUf+N4UFJdko+n4wjqbMr+a789ONF6IcCom8VoIb2+tXmZtIR0+CgkwJulGRMS/rmd5MJ/M25GSxHQoCX9BCi3SgQy/BPU4rzMXHfTztl49zWpdDwvppX6YzMh4DxAXu/x8/UhDPNVB9nJpl03XVVlAtupfO+Mk/zruVAZNxfQobEbTRiLNLZdbTCHmwbLy5gFnhHX6IwN+9d6nhWQXaWo32JkWbaEmB8tSMDyfVJQcUKKTSwzOa2nWnNtHS5BYV9wFXo3vPY2reyEoBtVsMDKv2p2WWgDL9jtJVAFOc6Ll77CotUIgSixIafhG4cScJorDlvxlnEDCN7WIp5v3BpUS3aJxekSJOzMSnHtl7NlL0Hu9FaDSmfbOtZhMUk/JIazlRRy++YjrAEoTplRzU26rvHaNiTmRHg6pZR7Ngtj6OdUkpS83HwOB/3JQuNfycyuaXoMyibv2ytqi7IE2uoFHqRTp7H4+ryoNlH+F+HwJ5roUG7nPNChuTwvFAYUf9bVfV6xag6KO2WGtFK3jCWjEy0bMMVHvrt8Wn+4+HkiNETBAUbbWm4f++xtNvQL2s80DGyv1ePi1fCFBNiQFk++sutAovGYL5eQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", new CultureInfo("de-DE"));
            manager.IncludeAlpha = true;
            manager.IncludeBeta = true;

            if (manager.SearchForUpdates())
            {
                await manager.DownloadPackagesAsync();
                manager.InstallPackage();
            }

            await Task.Delay(1500);

            AppManager.Instance.Load<LoginViewController>();
        }
    }
}