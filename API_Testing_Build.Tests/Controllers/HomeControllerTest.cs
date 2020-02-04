using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API_Testing_Build;
using API_Testing_Build.Controllers;

namespace API_Testing_Build.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
