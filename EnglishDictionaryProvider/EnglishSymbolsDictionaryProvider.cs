using System;
using System.Collections.Generic;
using TransformerDictionaryComposition;

namespace EnglishDictionaryProvider
{
    public class EnglishSymbolsDictionaryProvider : ISymbolsDictionaryProvider
    {
        public IReadOnlyDictionary<Symbol, string> CreateSymbolsDictionary() => throw new NotImplementedException();
    }
}