using System;
using TransformerDictionaryComposition;

namespace GermanDictionaryProvider
{
    /// <summary>
    /// Presents the provider of the dictionary of symbols of the german language.
    /// </summary>
    public class GermanSymbolsDictionaryProvider : ISymbolsDictionaryProvider
    {
        /// <inheritdoc cref="ISymbolsDictionaryProvider.CreateSymbolsDictionary"/>
        public SymbolsDictionary CreateSymbolsDictionary() => throw new NotImplementedException();
    }
}
