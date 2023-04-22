using System.Globalization;
using ResourcesDictionaryFactory.Resources;

namespace ConverterComposition.Tests
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in given language.
    /// </summary>
    public class ResourceCharsDictionaryFactory : ICharsDictionaryFactory
    {
        private string? cultureName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCharsDictionaryFactory"/> class.
        /// </summary>
        /// <param name="cultureName">Name of the culture.</param>
        /// <exception cref="System.ArgumentException">Thrown when cultureName is null or empty.</exception>
        public ResourceCharsDictionaryFactory(string? cultureName)
        {
            Dictionary.Culture = cultureName is null
                ? throw new ArgumentException($"{nameof(cultureName)} cannot be null or empty.", nameof(cultureName))
                : new CultureInfo(cultureName);
            this.cultureName = cultureName;
        }

        /// <inheritdoc cref="ICharsDictionaryFactory.CreateDictionary"/>
        public CharsDictionary CreateDictionary()
        {
            return new CharsDictionary()
            {
                Dictionary = new Dictionary<Character, string>
                {
                    [Character.Zero] = Dictionary.Zero,
                    [Character.One] = Dictionary.One,
                    [Character.Two] = Dictionary.Two,
                    [Character.Three] = Dictionary.Three,
                    [Character.Four] = Dictionary.Four,
                    [Character.Five] = Dictionary.Five,
                    [Character.Six] = Dictionary.Six,
                    [Character.Seven] = Dictionary.Seven,
                    [Character.Eight] = Dictionary.Eight,
                    [Character.Nine] = Dictionary.Nine,
                    [Character.Minus] = Dictionary.Minus,
                    [Character.Plus] = Dictionary.Plus,
                    [Character.Point] = Dictionary.Point,
                    [Character.Comma] = Dictionary.Comma,
                    [Character.Exponent] = Dictionary.Exponent,
                    [Character.Epsilon] = Dictionary.Epsilon,
                    [Character.NegativeInfinity] = Dictionary.NegativeInfinity,
                    [Character.PositiveInfinity] = Dictionary.PositiveInfinity,
                    [Character.NaN] = Dictionary.NaN,
                },
                CultureName = this.cultureName,
            };
        }
    }
}
