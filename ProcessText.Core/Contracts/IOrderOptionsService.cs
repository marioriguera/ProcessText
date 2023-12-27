using System.Collections.Generic;
using ProcessText.Core.Contracts.Models;

namespace ProcessText.Core.Contracts
{
    /// <summary>
    /// Defines the contract for an order options service.
    /// </summary>
    public interface IOrderOptionsService
    {
        /// <summary>
        /// Retrieves a dictionary of order options with their respective IDs.
        /// </summary>
        /// <returns>A dictionary where the key is the ID of the order option and the value is the IOrderOption instance.</returns>
        IEnumerable<IOrderOption> GetOrderOptions();
    }
}
