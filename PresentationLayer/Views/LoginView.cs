using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DomainLayer.Models;
using DomainLayer.Repositories;

namespace PresentationLayer.Views
{
    public partial class LoginView : KryptonForm
    {
        private static LoginView _loginView;
        public static LoginView Instance
        {
            get
            {
                if (_loginView == null)
                {
                    _loginView = new LoginView();
                }
                return _loginView;
            }
        }

        public LoginView()
        {
            InitializeComponent();
            _loginView = this;
        }

       
        private async void signInButton_Click(object sender, EventArgs e)
        {
            CountDownTimer timer = new CountDownTimer();
            LoginModel loginModel = new LoginModel() ;
            loginModel.Password = this.passwordTextBox.Text;
            loginModel.Username = this.usernameTextBox.Text;

            AuthRepository repository = new AuthRepository();
            bool success = await repository.Login(loginModel);

            if (!success)
            {
                this.invalidCredentialsLabel.Visible = true;
                timer.SetTime(0, 3); // 3 seconds
                timer.Start();
                timer.CountDownFinished += () => this.invalidCredentialsLabel.Visible = false;
                timer.Dispose();
            } 
            else
            {
                this.invalidCredentialsLabel.Visible = false;
                this.Close();
                DialogResult = DialogResult.OK;
            }

        }
    }

   
}
