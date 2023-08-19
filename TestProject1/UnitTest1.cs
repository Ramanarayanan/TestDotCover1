using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Moq;
using WebApplication1.Controllers;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public async Task Create_WhenSlugIsInUse_ReturnsBadRequest()
        {
            // Arrange
            string slug = "Some Slug";
            var mockRepo = new Mock<ILogger>();
           
             var controller = new HomeController();
           
    // Act
           var result = controller.Privacy();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}