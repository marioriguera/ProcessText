using System.Collections.Generic;
using System.Linq;
using Moq;
using ProcessText.Core.Business;
using ProcessText.Core.Contracts.Models;
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
            // Arrange
            var mockOrderOption = new Mock<IOrderOption>();
            var orderOptions = new List<IOrderOption>
                               {
                                   mockOrderOption.Object,
                                   mockOrderOption.Object,
                                   mockOrderOption.Object,
                               };

            // ToDo: In production, change OrderOptionsService to internal. An this to IOrderOptionsService. 
            var orderOptionsService = new Mock<OrderOptionsService>();

            // Act
            orderOptionsService.Object.SetOrderOptions(orderOptions);
            var result = orderOptionsService.Object.GetOrderOptions();

            // Assert
            Assert.Equal(3, result.ToList().Count);
        }
    }
}