using System.Windows.Forms;

namespace DedSecDns_Client.Core.MVC
{
    public interface IView
    {
        Form Form { get; }
        string Title { get; set; }

        void Close();
    }
}