using ChapterSonar.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace UnitTest
{
    public class ControllerTest
    {
        private WeatherForecastController controller; 
        private Mock<ILogger<WeatherForecastController>> mock; 

        public ControllerTest()
        {
            mock = new Mock<ILogger<WeatherForecastController>>();
            controller = new WeatherForecastController(mock.Object);
        }

        [Fact]
        public void Test1()
        {
            var result = controller.Get();
            Assert.NotNull(result);
        }
    }
}
