using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using ProcessText.Core.Contracts;
using ProcessText.Core.Contracts.Models;
using System.Collections.Generic;
using System.Linq;
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
        public void GetOrderOptions_ReturnsCorrectNumberOfElements_Three()
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