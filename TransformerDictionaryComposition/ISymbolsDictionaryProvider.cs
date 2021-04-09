using System.Collections.Generic;

namespace TransformerDictionaryComposition
{
    public interface ISymbolsDictionaryProvider
    {
        IReadOnlyDictionary<Symbol, string> CreateSymbolsDictionary();
    }
}