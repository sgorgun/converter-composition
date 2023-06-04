using System;
using System.Globalization;
using System.Text;

namespace ConverterComposition
{
    /// <summary>
    /// Converts a real number to string.
    /// </summary>
    public class Converter
    {
        private readonly CharsDictionary dictionaryFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="Converter"/> class.
        /// </summary>
        /// <param name="dictionaryFactory">Factory of the dictionary with rules of converting.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when dictionary factory is null.</exception>
        public Converter(ICharsDictionaryFactory? dictionaryFactory)
        {
            this.dictionaryFactory = dictionaryFactory is null ? throw new ArgumentNullException(nameof(dictionaryFactory), "Dictionary factory is can't be null") : dictionaryFactory.CreateDictionary();
        }

        /// <summary>
        /// Converts double number into string.
        /// </summary>
        /// <param name="number">Double number to convert.</param>
        /// <returns>A number string representation.</returns>
        public string Convert(double number)
        {
            return double.IsNaN(number) || double.IsInfinity(number) || number == double.Epsilon ? this.ConvertSpecial(number) : this.ConvertNumber(number);
        }

        private string ConvertNumber(double number)
        {
            StringBuilder sb = new StringBuilder();

            var strNum = number.ToString(new CultureInfo(this.dictionaryFactory.CultureName!));

            foreach (var ch in strNum)
            {
                sb.Append(ch switch
                {
                    '0' => this.dictionaryFactory.Dictionary![Character.Zero],
                    '1' => this.dictionaryFactory.Dictionary![Character.One],
                    '2' => this.dictionaryFactory.Dictionary![Character.Two],
                    '3' => this.dictionaryFactory.Dictionary![Character.Three],
                    '4' => this.dictionaryFactory.Dictionary![Character.Four],
                    '5' => this.dictionaryFactory.Dictionary![Character.Five],
                    '6' => this.dictionaryFactory.Dictionary![Character.Six],
                    '7' => this.dictionaryFactory.Dictionary![Character.Seven],
                    '8' => this.dictionaryFactory.Dictionary![Character.Eight],
                    '9' => this.dictionaryFactory.Dictionary![Character.Nine],
                    '+' => this.dictionaryFactory.Dictionary![Character.Plus],
                    '-' => this.dictionaryFactory.Dictionary![Character.Minus],
                    '.' => this.dictionaryFactory.Dictionary![Character.Point],
                    ',' => this.dictionaryFactory.Dictionary![Character.Comma],
                    'E' => this.dictionaryFactory.Dictionary![Character.Exponent],
                    _ => ' ',
                });
                sb.Append(' ');
            }

            return sb.ToString().Trim();
        }

        private string ConvertSpecial(double number) =>
            number switch
            {
                double.NaN => this.dictionaryFactory.Dictionary![Character.NaN],
                double.PositiveInfinity => this.dictionaryFactory.Dictionary![Character.PositiveInfinity],
                double.NegativeInfinity => this.dictionaryFactory.Dictionary![Character.NegativeInfinity],
                double.Epsilon => this.dictionaryFactory.Dictionary![Character.Epsilon],
                _ => string.Empty,
            };
    }
}
