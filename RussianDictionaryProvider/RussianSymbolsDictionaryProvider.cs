using System;
using System.Collections.Generic;
using TransformerDictionaryComposition;

namespace RussianDictionaryProvider
{
    public class RussianSymbolsDictionaryProvider : ISymbolsDictionaryProvider
    {
        public IReadOnlyDictionary<Symbol, string> CreateSymbolsDictionary() => throw new NotImplementedException();
    }
}