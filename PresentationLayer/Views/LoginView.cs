using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CommonLayer;
using ComponentFactory.Krypton.Toolkit;


namespace PresentationLayer.Views
{
    public partial class LoginView : KryptonForm, ILoginView
    {
        public event EventHandler LoginViewLoadEventRaised;
        public event EventHandler<DataEventArgs> LoginButtonClickEventRaised;


        public LoginView()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Username", this.usernameTextBox.Text);
            data.Add("Password", this.passwordTextBox.Text);
            DataEventArgs ev = new DataEventArgs() { data = data};
            EventHelpers.RaiseEvent(this, LoginButtonClickEventRaised, ev);
        }

        public void CloseForm()
        {
            this.invalidCredentialsLabel.Visible = false;
            this.Close();
            DialogResult = DialogResult.OK;
        }

        public DialogResult ShowLoginView()
        {
             return this.ShowDialog();
        }

        public void ShowOrHideInvalidCredentialsLabel(bool value)
        {
            this.invalidCredentialsLabel.Visible = value;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, LoginViewLoadEventRaised, e);
        }
    }


}
