using System;
using System.Windows.Forms;

namespace DedSecDns_Client.Core.MVC
{
    public abstract class Controller
    {
        public abstract IView View { get; }

        public Controller()
        {
            LoadSuccess += OnLoadSucceededHandler;
            LoadFailed += OnLoadFailedHandler;
        }

        public event EventHandler LoadSuccess, LoadFailed;

        public abstract bool Loadable();

        public void OnLoadFailure(EventArgs e)
        {
            if (LoadFailed != null)
                LoadFailed(this, e);
        }

        public void OnLoadSuccess(EventArgs e)
        {
            if (LoadSuccess != null)
                LoadSuccess(this, e);
        }

        protected virtual void OnLoadFailedHandler(object sender, EventArgs e)
        {
            if (MessageBox.Show("You don't have access to load this page.\nThe application will exit now.") == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        protected virtual void OnLoadSucceededHandler(object sender, EventArgs e)
        {
            AppManager.Instance.Show(this);
        }
    }
}