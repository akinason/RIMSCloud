using CommonLayer;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public interface ILoginPresenter
    {
        ILoginView GetLoginView { get; }

        void OnLoginButtonClickEventRaised(object sender, DataEventArgs e);
    }
}