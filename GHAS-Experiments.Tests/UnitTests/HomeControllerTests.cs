using NUnit.Framework;
using GhasExperiments.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GhasExperiments.Tests.UnitTests
{
    public class HomeControllerTests
    {
        private HomeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new HomeController();
        }

        [Test]
        public void Index_Returns_ViewResult()
        {
            // Act
            var result = _controller.Index();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}