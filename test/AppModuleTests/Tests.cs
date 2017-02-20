using Xunit;
using Nancy;
using Nancy.Testing;

namespace Tests
{
    public class AppModuleTests{
        [Fact]
        public void ShouldReturnFriendlyBanner() {
            
            // Given
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(bootstrapper);
            // When
            var result = browser.Get("/", with => {
                with.HttpRequest();
            });

            // Then
            Assert.Equal(HttpStatusCode.OK, result.Result.StatusCode);
            Assert.Equal("Super Duper Happy Path", result.Result.Body.AsString());
        }
    }
}
