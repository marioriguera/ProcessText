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
        private readonly IOrderOptionsService _orderOptionsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderOptionTests"/> class.
        /// </summary>
        public GetOrderOptionTests()
        {
            // Obtain the IOrderOptionsService from the service collection
            _orderOptionsService = ConfigurationServiceTests.Current.TestHost.Services.GetRequiredService<IOrderOptionsService>();
        }

        /// <summary>
        /// Ensures that GetOrderOptions returns the correct number of elements (three).
        /// </summary>
        [Fact]
        public void GetOrderOptions_ReturnsCorrectNumberOfElements()
        {
            // Act
            var result = _orderOptionsService.GetOrderOptions();

            // Assert
            Assert.Equal(3, result.ToList().Count);
        }
    }
}