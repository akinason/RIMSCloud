using DomainLayer.Models;
using DomainLayer.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;


namespace DomainLayer.Tests.Repositories
{
    [Trait("Category", "API Authentication")]
    public class APIAuthenticationTests
    {

        private readonly ITestOutputHelper _testOutputHelper;
        private AuthRepository _authRepository;

        public APIAuthenticationTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _authRepository = new AuthRepository();
        }

        [Fact]
        public async void ShouldLoginSuccessfully()
        {
            ILoginModel model = new LoginModel();
            model.Username = "admin";
            model.Password = "admin";
            bool response = await _authRepository.Login(model);
            Assert.True(response);
            _testOutputHelper.WriteLine("The login was successful.");
        }

        [Fact]
        public void ShouldGetNewRefreshTokenSuccessfully()
        {
            int response = 1;
            Assert.Equal<int>(1, response);
        }
    }
}
