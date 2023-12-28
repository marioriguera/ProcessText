using Microsoft.Extensions.DependencyInjection;
using ProcessText.Core.Contracts.Factory;
using Xunit;

namespace ProcessText.Tests
{
    public class OrderFactoryTests
    {
        private IOrderFactory _orderFactory;

        public OrderFactoryTests()
        {
            _orderFactory = ConfigurationServiceTests.Current.TestHost.Services.GetRequiredService<IOrderFactory>();
        }

        [Fact]
        public void AlphabeticAscTest()
        {
            // var result = _orderFactory.
        }
    }
}
