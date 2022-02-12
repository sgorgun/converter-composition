using System;
using System.Collections.Generic;
using System.Globalization;
using ResourcesDictionaryProvider.Resources;
using TransformerDictionaryComposition;

namespace ResourcesDictionaryProvider
{
    /// <summary>
    /// Presents the provider of the dictionary of symbols of the german language.
    /// </summary>
    public class ResourceSymbolsDictionaryProvider : ISymbolsDictionaryProvider
    {
        private string? cultureName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceSymbolsDictionaryProvider"/> class.
        /// </summary>
        /// <param name="cultureName">Name of the culture.</param>
        public ResourceSymbolsDictionaryProvider(string? cultureName)
        {
            Dictionary.Culture = cultureName is null
                ? throw new ArgumentNullException(nameof(cultureName))
                : new CultureInfo(cultureName);
            this.cultureName = cultureName;
        }

        /// <inheritdoc cref="ISymbolsDictionaryProvider.CreateSymbolsDictionary"/>
        public SymbolsDictionary CreateSymbolsDictionary()
        {
            return new SymbolsDictionary()
            {
                Dictionary = new Dictionary<Symbol, string>
                {
                    [Symbol.Zero] = Dictionary.Zero, 
                    [Symbol.One] = Dictionary.One, 
                    [Symbol.Two] = Dictionary.Two,
                    //TODO
                },
                CultureName = this.cultureName,
            };
        }
    }
}
