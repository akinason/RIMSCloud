using DomainLayer.Models;
using DomainLayer.Repositories;
using DomainLayer.Services;
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
        public async Task TestShouldLoginSuccessfullyWithValidCrentials()
        {
            ILoginModel model = new LoginModel();
            model.Username = "admin";
            model.Password = "admin";
            bool response = await _authRepository.Login(model);
            Assert.True(response);
            _testOutputHelper.WriteLine("The valid login was successful.");
        }

        [Fact]
        public async Task TestShouldFailLoginWithInvalidCredentials()
        {
            ILoginModel model = new LoginModel();
            model.Username = "testad";
            model.Password = "testdd";
            bool response = await _authRepository.Login(model);
            Assert.False(response);
            _testOutputHelper.WriteLine("The failed login was successful.");
        }

        [Fact]
        public async Task TestShouldSuccesfullyRefreshToken()
        {
            // Login so as to create valid credentials. 
            ILoginModel loginModel = new LoginModel() { Password = "admin", Username = "admin" };
            AuthRepository authRepository = new AuthRepository();
            bool success = await authRepository.Login(loginModel);
            Assert.True(success);

            // Modify the Token so it becomes invalid.
            ApiClient.Token = $"{ApiClient.Token}invalid";

            ApiClient client = new ApiClient();
            await client.GetNewTokenUsingRefreshToken();
            Assert.DoesNotContain("invalid", ApiClient.Token);
        }

        [Fact]
        public async Task TestShouldFailGettingNewTokenWithInvalidRefreshToken()
        {
            // Login so as to create valid credentials. 
            ILoginModel loginModel = new LoginModel() { Password = "admin", Username = "admin" };
            AuthRepository authRepository = new AuthRepository();
            bool success = await authRepository.Login(loginModel);
            Assert.True(success);

            string token = ApiClient.Token;

            ApiClient.RefreshToken = $"{ApiClient.RefreshToken}invalidate";
            ApiClient client = new ApiClient();
            await client.GetNewTokenUsingRefreshToken();
            Assert.Equal(ApiClient.Token, token);
            string rt = ApiClient.RefreshToken;
            Assert.Contains(rt.Substring(rt.Length - "invalidate".Length), "invalidate");
        }
    }
}
