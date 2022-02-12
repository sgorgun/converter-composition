namespace TransformerDictionaryComposition
{
    /// <summary>
    /// Presents the provider of the dictionary of symbols.
    /// </summary>
    public interface ISymbolsDictionaryProvider
    {
        /// <summary>
        /// Provides the dictionary of base symbols.
        /// </summary>
        /// <returns>The dictionary of base symbols.</returns>
        SymbolsDictionary CreateSymbolsDictionary();
    }
}
