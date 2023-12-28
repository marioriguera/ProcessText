using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using ProcessText.Core.Contracts.Factory;
using Xunit;

namespace ProcessText.Tests
{
    /// <summary>
    /// Represents unit tests for the IOrderFactory with AlphabeticDesc order to ensure correct order generation.
    /// </summary>
    public class OrderFactoryAlphabeticDescTests
    {
        private IOrderFactory _orderFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFactoryAlphabeticDescTests"/> class.
        /// </summary>
        public OrderFactoryAlphabeticDescTests()
        {
            _orderFactory = ConfigurationServiceTests.Current.TestHost.Services.GetRequiredService<IOrderFactory>();
        }

        /// <summary>
        /// Tests the AlphabeticDesc order with a basic input.
        /// </summary>
        [Fact]
        public void AlphabeticDesc_Basic_Test()
        {
            var result = _orderFactory.GetOrderText("AlphabeticDesc", "Aaa Bbb Ccc").ToList();

            Assert.Equal("Ccc", result.First());
            Assert.Equal("Bbb", result.Skip(1).First());
            Assert.Equal("Aaa", result.Skip(2).First());
        }

        /// <summary>
        /// Tests the AlphabeticDesc order with names as input.
        /// </summary>
        [Fact]
        public void AlphabeticDesc_Names_Test()
        {
            var result = _orderFactory.GetOrderText("AlphabeticDesc", "Mario Antonia Pedro").ToList();

            Assert.Equal("Pedro", result.First());
            Assert.Equal("Mario", result.Skip(1).First());
            Assert.Equal("Antonia", result.Skip(2).First());
        }

        /// <summary>
        /// Tests the AlphabeticDesc order with an empty input.
        /// </summary>
        [Fact]
        public void AlphabeticDesc_Empty_Test()
        {
            var result = _orderFactory.GetOrderText("AlphabeticDesc", string.Empty).ToList();

            Assert.Empty(result);
        }

        /// <summary>
        /// Tests the AlphabeticDesc order with a null input, expecting a NullReferenceException.
        /// </summary>
        [Fact]
        public void AlphabeticDesc_Null_Test()
        {
            Assert.Throws<NullReferenceException>(() => _orderFactory.GetOrderText("AlphabeticDesc", null).ToList());
        }
    }
}
