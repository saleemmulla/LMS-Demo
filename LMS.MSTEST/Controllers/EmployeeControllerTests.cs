using System;
using LMS.WEB.Portal.Controllers;
using LMS.WEB.Portal.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LMS.MSTEST.Controllers
{
    [TestClass]
    public class EmployeeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var mockIUserDetailRepository = new Mock<IUserDetailRepository>();
            var mockILeaveRepository = new Mock<ILeaveRepository>();
            EmployeeController controller = new EmployeeController(mockIUserDetailRepository.Object,mockILeaveRepository.Object);
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ApplyLeave_IsNull()
        {
            // Arrange
            var mockIUserDetailRepository = new Mock<IUserDetailRepository>();
            var mockILeaveRepository = new Mock<ILeaveRepository>();
            EmployeeController controller = new EmployeeController(mockIUserDetailRepository.Object, mockILeaveRepository.Object);
            // Act
            ViewResult result = null;
            try
            {
                result = controller.ApplyLeave() as ViewResult;
            }
            catch
            {
                
            }
            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ApplyLeave_WithSessionMock()
        {
            // Arrange
            var mockIUserDetailRepository = new Mock<IUserDetailRepository>();
            var mockILeaveRepository = new Mock<ILeaveRepository>();
            EmployeeController controller = new EmployeeController(mockIUserDetailRepository.Object, mockILeaveRepository.Object);
                  
            // Act
            ViewResult result = null;
            try
            {
                result = controller.ApplyLeave() as ViewResult;
            }
            catch
            {

            }
            // Assert
            Assert.IsNull(result);
        }
    }
}
