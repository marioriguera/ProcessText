using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using ProcessText.Core.Contracts.Factory;
using Xunit;

namespace ProcessText.Tests
{
    /// <summary>
    /// Represents unit tests for the IOrderFactory with LengthAsc order to ensure correct order generation.
    /// </summary>
    public class OrderFactoryLegthAscTests
    {
        private readonly IOrderFactory _orderFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFactoryLegthAscTests"/> class.
        /// </summary>
        public OrderFactoryLegthAscTests()
        {
            _orderFactory = ConfigurationServiceTests.Current.TestHost.Services.GetRequiredService<IOrderFactory>();
        }

        /// <summary>
        /// Tests the LengthAsc order with a basic input.
        /// </summary>
        [Fact]
        public void LengthAsc_Basic_Test()
        {
            var result = _orderFactory.GetOrderText("LengthAsc", "A Bb Ccc").ToList();

            Assert.Equal("A", result.First());
            Assert.Equal("Bb", result.Skip(1).First());
            Assert.Equal("Ccc", result.Skip(2).First());
        }

        /// <summary>
        /// Tests the LengthAsc order with names as input.
        /// </summary>
        [Fact]
        public void LengthAsc_Names_Test()
        {
            var result = _orderFactory.GetOrderText("LengthAsc", "Mario Antonia Pepe").ToList();

            Assert.Equal("Pepe", result.First());
            Assert.Equal("Mario", result.Skip(1).First());
            Assert.Equal("Antonia", result.Skip(2).First());
        }

        /// <summary>
        /// Tests the LengthAsc order with an empty input, expecting an empty enumeration.
        /// </summary>
        [Fact]
        public void LengthAsc_Empty_Test()
        {
            var result = _orderFactory.GetOrderText("LengthAsc", string.Empty).ToList();

            Assert.Empty(result);
        }

        /// <summary>
        /// Tests the LengthAsc order with a null input, expecting an empty enumeration.
        /// </summary>
        [Fact]
        public void LengthAsc_Null_Test()
        {
            var result = _orderFactory.GetOrderText("LengthAsc", null).ToList();

            Assert.Empty(result);
        }
    }
}
