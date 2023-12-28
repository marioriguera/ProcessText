using ProcessText.Core.Contracts.Models;

namespace ProcessText.Core.Models
{
    /// <summary>
    /// Represents an implementation of the ITextStatistics interface for collecting statistics on text content.
    /// </summary>
    internal class TextStatistics : ITextStatistics
    {
        /// <inheritdoc/>
        public ulong WordCount { get; set; }

        /// <inheritdoc/>
        public ulong SpaceCount { get; set; }

        /// <inheritdoc/>
        public ulong HyphenCount { get; set; }
    }
}
