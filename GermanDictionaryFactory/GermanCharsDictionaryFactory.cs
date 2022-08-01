using System;
using ConverterDictionaryComposition;

namespace GermanDictionaryFactory
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in german.
    /// </summary>
    public class GermanCharsDictionaryFactory : ICharsDictionaryFactory
    {
        /// <inheritdoc href="ConverterDictionaryComposition.CreateDictionary"/>
        public CharsDictionary CreateDictionary() => throw new NotImplementedException();
    }
}
