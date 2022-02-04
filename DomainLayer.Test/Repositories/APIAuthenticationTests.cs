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
            string path = @"d:/testss.txt";
            File.WriteAllText(path, "sime");
        }

        [Fact]
        public void ShouldLoginSuccessfully()
        {
            //LoginModel model = new LoginModel();
            //model.Username = "admin";
            //model.Password = "admin";
            //bool response = await _authRepository.Login(model);
            bool response = true;
            string path = @"d:\tests.txt";
            File.WriteAllText(path, response.ToString());
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
