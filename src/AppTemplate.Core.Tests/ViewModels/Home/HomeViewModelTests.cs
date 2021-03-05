using Xunit;

namespace AppTemplate.Core.Tests.ViewModels.Home
{
    public class HomeViewModelTests
    {
        [Fact]
        public void AppVersion_Returns_Correct_Version_From_Service()
        {
            // Arrange
            var wrapper = new HomeViewModelTestWrapper();
            var sut = wrapper.GetSubject();

            // Act
            var result = sut.AppVersion;

            // Assert
            Assert.Equal(wrapper.TestAppVersion, result);
        }
    }
}
