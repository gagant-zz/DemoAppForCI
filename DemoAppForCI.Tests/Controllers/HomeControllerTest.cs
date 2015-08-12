using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using DemoAppForCI;
using DemoAppForCI.Controllers;
using NUnit.Framework;

namespace DemoAppForCI.Tests.Controllers
{
    
    public class HomeControllerTest
    {
        [TestCase]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestCase]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestCase]
        
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result =  controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
