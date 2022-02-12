using System.Collections.Generic;

namespace TransformerDictionaryAggregation
{
    /// <summary>
    /// Class presents dictionary of base symbols and culture.
    /// </summary>
    public class SymbolsDictionary
    {
        /// <summary>
        /// The dictionary of base symbols.
        /// </summary>
        public IReadOnlyDictionary<Symbol, string>? Dictionary { get; set; }

        /// <summary>
        /// The culture.
        /// </summary>
        public string? CultureName { get; set; }
    }
}
