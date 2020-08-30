using LMS.WEB.Portal.Controllers;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.MSTEST.Controllers
{
    [TestClass]
    public class AccountControllerTests
    {
        [TestMethod]
        public void LogIn()
        {
            // Arrange
            var mockILoginRepository = new Mock<ILoginRepository>();
            AccountController controller = new AccountController(mockILoginRepository.Object);
            // Act
            ViewResult result = controller.LogIn() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void LogInPost_With_Wrong_Input()
        {
            // Arrange
            var mockILoginRepository = new Mock<ILoginRepository>();
            AccountController controller = new AccountController(mockILoginRepository.Object);
            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.UserName = "saleem";
            // Act
            Task<ActionResult> taskResult = controller.LogIn(loginViewModel) as Task<ActionResult>;
            // Assert
            Assert.IsNotNull(taskResult);
            Assert.IsTrue((taskResult.Result as ViewResult) != null);

        }
        [TestMethod]
        public void LogInPost_Mock_GetLoggedInUser()
        {
            // Arrange
            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.UserName = "saleemmulla";
            loginViewModel.Password = "S123333";
            loginViewModel.Role = "Employee";

            var mockILoginRepository = new Mock<ILoginRepository>();
            mockILoginRepository.Setup(x => x.GetLoggedInUser(It.IsAny<string>(), It.IsAny<string>())).Returns(loginViewModel);
            AccountController controller = new AccountController(mockILoginRepository.Object);
          
            // Act
            Task<ActionResult> taskResult = controller.LogIn(loginViewModel) as Task<ActionResult>;
            // Assert
            Assert.IsNotNull(taskResult);

        }
    }
}
