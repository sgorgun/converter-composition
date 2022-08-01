using System;
using ConverterDictionaryComposition;

namespace EnglishDictionaryFactory
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in english.
    /// </summary>
    public class EnglishCharsDictionaryFactory : ICharsDictionaryFactory
    {
        /// <inheritdoc cref="ICharsDictionaryFactory.CreateDictionary"/>
        public CharsDictionary CreateDictionary() => throw new NotImplementedException();
    }
}
