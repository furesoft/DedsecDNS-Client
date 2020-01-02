using System.Windows.Forms;

namespace DedSecDns_Client.Core.Controls
{
    public partial class NotificationControl : UserControl
    {
        public string Message
        {
            get { return messageLbl.Text; }
            set
            {
                messageLbl.Text = value;
                //xuiObjectAnimator1.StandardAnimate(borderPanel, XanderUI.XUIObjectAnimator.StandardAnimation.SlideUp, 1500);
                hideTimer.Start();
            }
        }

        public NotificationControl()
        {
            InitializeComponent();
        }

        private void hideTimer_Tick(object sender, System.EventArgs e)
        {
            xuiObjectAnimator1.StandardAnimate(borderPanel, XanderUI.XUIObjectAnimator.StandardAnimation.SlideDown, 1500);
            hideTimer.Stop();
            Hide();
        }

        private void NotificationControl_Load(object sender, System.EventArgs e)
        {
        }
    }
}