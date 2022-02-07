using DomainLayer.Models;
using DomainLayer.Repositories;
using DomainLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DomainLayer.Test.Repositories
{
    [Trait("Category", "Dashboard Repository")]
    public class DashboardRepositoryTests
    {

        [Fact]
        public async void TestShouldGetDasboardAnalyticsWithValidCredentials()
        {
            // Login so as to create valid credentials. 
            ILoginModel loginModel = new LoginModel() { Password = "admin", Username = "admin" };
            AuthRepository authRepository = new AuthRepository();
            bool success = await authRepository.Login(loginModel);
            Assert.True(success);

            DashboardRepository repository = new DashboardRepository();
            IDashboardModel dashboard = await repository.GetDasbhoardData();
            Assert.NotNull(dashboard);
            Assert.True(dashboard.ProjectStatus.Active >= 0, "Active projects are not greater than or equal to zero");
        }

        [Fact]
        public async void TestShouldRefreshTokenAndProceedWithExtractingDashboardData()
        {
            // Login so as to create valid credentials. 
            ILoginModel loginModel = new LoginModel() { Password = "admin", Username = "admin" };
            AuthRepository authRepository = new AuthRepository();
            bool success = await authRepository.Login(loginModel);
            Assert.True(success);

            DashboardRepository repository = new DashboardRepository();
            IDashboardModel dashboard = await repository.GetDasbhoardData();
            Assert.NotNull(dashboard);
            Assert.True(dashboard.ProjectStatus.Active >= 0, "Active projects are not greater than or equal to zero");
        }
    }
}
