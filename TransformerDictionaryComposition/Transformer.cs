using System;
using System.Collections.Generic;
using System.Globalization;

namespace TransformerDictionaryComposition
{
    /// <summary>
    /// Provides transforming double number to its string representation with specified dictionary.
    /// </summary>
    public class Transformer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transformer"/> class.
        /// </summary>
        /// <param name="symbolsDictionaryProvider">Provider of the dictionary with rules of transforming.</param>
        public Transformer(ISymbolsDictionaryProvider? symbolsDictionaryProvider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Transforms double number into string.
        /// </summary>
        /// <param name="number">Double number to transform.</param>
        /// <returns>Transformed value.</returns>
        public string Transform(double number)
        {
            throw new NotImplementedException();
        }
    }
}
