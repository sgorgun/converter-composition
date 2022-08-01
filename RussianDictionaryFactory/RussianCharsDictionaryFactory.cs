using System;
using ConverterDictionaryComposition;

namespace RussianDictionaryFactory
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in russian.
    /// </summary>
    public class RussianCharsDictionaryFactory : ICharsDictionaryFactory
    {
        /// <inheritdoc cref="ICharsDictionaryFactory.CreateDictionary"/>
        public CharsDictionary CreateDictionary() => throw new NotImplementedException();
    }
}
