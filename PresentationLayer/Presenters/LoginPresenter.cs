using CommonLayer;
using DomainLayer.Models;
using DomainLayer.Repositories;
using PresentationLayer.Views;
using System;
using System.IO;

namespace PresentationLayer.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginView _loginView;

        public ILoginView GetLoginView { get { return _loginView; } }

        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
            SubscribeToEventsSetup();
        }

        private void SubscribeToEventsSetup()
        {
            _loginView.LoginButtonClickEventRaised += new EventHandler<DataEventArgs>(OnLoginButtonClickEventRaised);
        }

        public async void OnLoginButtonClickEventRaised(object sender, DataEventArgs e)
        {
            CountDownTimer timer = new CountDownTimer();
            ILoginModel loginModel = new LoginModel();
            loginModel.Password = e.data["Password"];
            loginModel.Username = e.data["Username"];
            AuthRepository repository = new AuthRepository();
            bool success = await repository.Login(loginModel);

            if (!success)
            {
                _loginView.ShowOrHideInvalidCredentialsLabel(true);
                timer.SetTime(0, 3); // 3 seconds
                timer.Start();
                timer.CountDownFinished += () => File.WriteAllText(@"d:/label.txt", "true"); //_loginView.ShowOrHideInvalidCredentialsLabel(false);
                timer.Dispose();
            }
            else
            {
                _loginView.CloseForm();
            }
        }
    }
}
