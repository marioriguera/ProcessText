using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessText.Core.Dependencies;

namespace ProcessText.Tests
{
    /// <summary>
    /// Manages configuration service values to tests.
    /// </summary>
    internal class ConfigurationServiceTests
    {
        #region Constructors

        /// <summary>
        /// Initializes static members of the <see cref="ConfigurationServiceTests"/> class.
        /// </summary>
        /// <remarks>
        /// Explicit static constructor to tell C# compiler not to mark type as before field initialization.
        /// </remarks>
        static ConfigurationServiceTests()
        {
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="ConfigurationServiceTests"/> class from being created.
        /// </summary>
        private ConfigurationServiceTests()
        {
            TestHost = Host.CreateDefaultBuilder().AddCoreDependencies().Build();
        }
        #endregion

        /// <summary>
        /// Gets current service configuration.
        /// </summary>
        public static ConfigurationServiceTests Current { get; } = new ConfigurationServiceTests();

        /// <summary>
        /// Gets or sets manage host to tests.
        /// </summary>
        public IHost TestHost { get; set; }
    }
}
