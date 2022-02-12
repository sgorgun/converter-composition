using System;
using TransformerDictionaryComposition;

namespace EnglishDictionaryProvider
{
    /// <summary>
    /// Presents the provider of the dictionary of symbols of the english language.
    /// </summary>
    public class EnglishSymbolsDictionaryProvider : ISymbolsDictionaryProvider
    {
        /// <inheritdoc cref="ISymbolsDictionaryProvider.CreateSymbolsDictionary"/>
        public SymbolsDictionary CreateSymbolsDictionary() => throw new NotImplementedException();
    }
}
