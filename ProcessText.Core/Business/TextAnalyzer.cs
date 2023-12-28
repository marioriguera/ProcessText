using System;
using System.Linq;
using ProcessText.Core.Contracts;
using ProcessText.Core.Contracts.Models;
using ProcessText.Core.Models;

namespace ProcessText.Core.Business
{
    /// <summary>
    /// Represents an implementation of the ITextAnalyzer interface for analyzing text and generating text statistics.
    /// </summary>
    internal class TextAnalyzer : ITextAnalyzer
    {
        /// <inheritdoc/>
        public ITextStatistics AnalyzeText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new TextStatistics(); // Returns an empty object if the string is null or empty
            }

            TextStatistics statistics = new TextStatistics();

            // Count words
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            statistics.WordCount = (ulong)words.Length;

            // Count white spaces
            statistics.SpaceCount = (ulong)text.Count(char.IsWhiteSpace);

            // Count hyphens '-'
            statistics.HyphenCount = (ulong)text.Count(c => c == '-');

            return statistics;
        }
    }
}
