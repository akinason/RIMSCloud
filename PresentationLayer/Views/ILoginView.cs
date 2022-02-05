using CommonLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public interface ILoginView
    {
        event EventHandler<DataEventArgs> LoginButtonClickEventRaised;
        event EventHandler LoginViewLoadEventRaised;

        void CloseForm();
        void ShowOrHideInvalidCredentialsLabel(bool value);
        DialogResult ShowLoginView();
    }
}