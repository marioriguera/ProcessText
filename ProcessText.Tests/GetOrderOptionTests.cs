using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using ProcessText.Core.Contracts;
using Xunit;

namespace ProcessText.Tests
{
    /// <summary>
    /// Unit test for the GetOrderOptions method in the OrderOptionsService class.
    /// </summary>
    public class GetOrderOptionTests
    {
        /// <summary>
        /// Ensures that GetOrderOptions returns the correct number of elements (three).
        /// </summary>
        [Fact]
        public void GetOrderOptions_ReturnsCorrectNumberOfElements()
        {
            // Take service
            var orderOptionsService = ConfigurationServiceTests.Current.TestHost.Services.GetRequiredService<IOrderOptionsService>();

            // Act
            var result = orderOptionsService.GetOrderOptions();

            // Assert
            Assert.Equal(3, result.ToList().Count);
        }
    }
}