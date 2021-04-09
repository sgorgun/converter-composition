using System.Collections.Generic;
using System.Globalization;
using ResourcesDictionaryProvider.Resources;
using TransformerDictionaryComposition;

namespace ResourcesDictionaryProvider
{
    public class ResourceSymbolsDictionaryProvider : ISymbolsDictionaryProvider
    {
        public ResourceSymbolsDictionaryProvider(string cultureName)
        {
            Dictionary.Culture = new CultureInfo(cultureName);
        }

        public IReadOnlyDictionary<Symbol, string> CreateSymbolsDictionary() => new Dictionary<Symbol, string>
        {
            [Symbol.Zero] = Dictionary.Zero,
            [Symbol.One] = Dictionary.One,
            [Symbol.Two] = Dictionary.Two,
            //TODO
        };
    }
}