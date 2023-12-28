using System.Collections.Generic;
using ProcessText.Core.Contracts.Models;

namespace ProcessText.Core.Contracts
{
    /// <summary>
    /// Represents an interface for analyzing text and generating text statistics.
    /// </summary>
    public interface ITextAnalyzer
    {
        /// <summary>
        /// Analyzes the provided text and returns an instance of ITextStatistics containing relevant statistics.
        /// </summary>
        /// <param name="text">The text to be analyzed.</param>
        /// <returns>An instance of ITextStatistics containing statistics on the provided text.</returns>
        ITextStatistics AnalyzeText(string text);

        /// <summary>
        /// Splits the provided text into an enumerable collection of strings.
        /// </summary>
        /// <param name="text">The text to be split.</param>
        /// <returns>An IEnumerable of strings representing the individual elements of the text.</returns>
        IEnumerable<string> SplitText(string text);
    }
}
