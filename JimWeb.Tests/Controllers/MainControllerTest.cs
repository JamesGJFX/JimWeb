using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JimWeb;
using JimWeb.Controllers;

namespace JimWeb.Tests.Controllers
{
    [TestClass]
    public class MainControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            MainController controller = new MainController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
