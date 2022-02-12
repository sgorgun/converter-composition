using System.Collections.Generic;

namespace TransformerDictionaryComposition
{
    /// <summary>
    /// Class presents dictionary of base symbols and culture.
    /// </summary>
    public class SymbolsDictionary
    {
        /// <summary>
        /// Gets or sets the dictionary of base symbols.
        /// </summary>
        public IReadOnlyDictionary<Symbol, string>? Dictionary { get; set; }

        /// <summary>
        /// The culture.
        /// </summary>
        public string? CultureName { get; set; }
    }
}
