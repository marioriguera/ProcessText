using System.Collections.Generic;
using System.Linq;
using ProcessText.Core.Contracts;
using ProcessText.Core.Contracts.Models;
using ProcessText.Core.Models;

namespace ProcessText.Core.Business
{
    /// <summary>
    /// Provides the implementation of the IOrderOptionsService interface.
    /// </summary>
    public class OrderOptionsService : IOrderOptionsService
    {
        private List<IOrderOption> _orderOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderOptionsService"/> class.
        /// </summary>
        public OrderOptionsService()
        {
            var options = new List<IOrderOption>()
                        {
                            { new OrderOption(1, "AlphabeticAsc", "Alfabetico ascendente") },
                            { new OrderOption(2, "AlphabeticDesc", "Alfabetico descendente") },
                            { new OrderOption(3, "LenghtAsc", "Tamaño ascendente") },
                        };

            SetOrderOptions(options);
        }

        /// <inheritdoc/>
        public IEnumerable<IOrderOption> GetOrderOptions()
        {
            return _orderOptions;
        }

        /// <inheritdoc/>
        public void SetOrderOptions(IEnumerable<IOrderOption> options)
        {
            if (_orderOptions != null)
            {
                _orderOptions.Clear();
            }

            _orderOptions = options.ToList();
        }
    }
}
