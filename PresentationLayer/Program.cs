using DomainLayer.Models;
using PresentationLayer.Presenters;
using PresentationLayer.Views;
using PresentationLayer.Views.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer UnityC;

            UnityC = new UnityContainer()
                // ********* Views ***********
                .RegisterType<ILoginView, LoginView>(new ContainerControlledLifetimeManager())
                .RegisterType<IDashboardView, DashboardView>(new ContainerControlledLifetimeManager())

                .RegisterType<IDashboardUC, IDashboardUC>(new ContainerControlledLifetimeManager())

                // ********** Presenters ******
                .RegisterType<ILoginPresenter, LoginPresenter>(new ContainerControlledLifetimeManager())


                // *********** Models *********
                 
                // Project Models
                .RegisterType<IDatasetModel, DatasetModel>(new ContainerControlledLifetimeManager())
                .RegisterType<IMemberModel, MemberModel>(new ContainerControlledLifetimeManager())
                .RegisterType<IProjectModel, ProjectModel>(new ContainerControlledLifetimeManager())

                // User Models
                .RegisterType<ILoginModel, LoginModel>(new ContainerControlledLifetimeManager())
                .RegisterType<IRoleModel, RoleModel>(new ContainerControlledLifetimeManager())
                .RegisterType<ITokenRequestModel, TokenRequestModel>(new ContainerControlledLifetimeManager())
                .RegisterType<IUserModel, UserModel>(new ContainerControlledLifetimeManager());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            ILoginPresenter loginPresenter = UnityC.Resolve<LoginPresenter>();
            ILoginView loginView = loginPresenter.GetLoginView;

            if (loginView.ShowLoginView() == DialogResult.OK)
            {
                Application.Run(new DashboardView());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
