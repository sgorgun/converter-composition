using System;
using System.Collections.Generic;
using NUnit.Framework;
using TransformerDictionaryAggregation;

namespace Transformer.Tests
{
    [TestFixture]
    public class TransformerAggregationTests
    {
        private IReadOnlyDictionary<Symbol, string> englishDictionary;
        private IReadOnlyDictionary<Symbol, string> russianDictionary;
        private IReadOnlyDictionary<Symbol, string> germanDictionary;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.englishDictionary = new Dictionary<Symbol, string>
            {
                [Symbol.Zero] = "zero",
                [Symbol.One] = "one",
                [Symbol.Two] = "two",
                [Symbol.Three] = "three",
                [Symbol.Four] = "four",
                [Symbol.Five] = "five",
                [Symbol.Six] = "six",
                [Symbol.Seven] = "seven",
                [Symbol.Eight] = "eight",
                [Symbol.Nine] = "nine",
                [Symbol.Minus] = "minus",
                [Symbol.Plus] = "plus",
                [Symbol.Point] = "point",
                [Symbol.Comma] = "comma",
                [Symbol.Exponent] = "exponent",
                [Symbol.Epsilon] = "epsilon",
                [Symbol.NegativeInfinity] = "negative infinity",
                [Symbol.PositiveInfinity] = "positive infinity",
                [Symbol.NaN] = "not a number",
            };

            this.russianDictionary = new Dictionary<Symbol, string>
            {
                [Symbol.Zero] = "ноль",
                [Symbol.One] = "один",
                [Symbol.Two] = "два",
                [Symbol.Three] = "три",
                [Symbol.Four] = "четыре",
                [Symbol.Five] = "пять",
                [Symbol.Six] = "шесть",
                [Symbol.Seven] = "семь",
                [Symbol.Eight] = "восемь",
                [Symbol.Nine] = "девять",
                [Symbol.Minus] = "минус",
                [Symbol.Plus] = "плюс",
                [Symbol.Point] = "точка",
                [Symbol.Comma] = "запятая",
                [Symbol.Exponent] = "экспонента",
                [Symbol.Epsilon] = "эпсилон",
                [Symbol.NegativeInfinity] = "отрицательная бесконечность",
                [Symbol.PositiveInfinity] = "положительная бесконечность",
                [Symbol.NaN] = "не число",
            };

            this.germanDictionary = new Dictionary<Symbol, string>
            {
                [Symbol.Zero] = "null",
                [Symbol.One] = "eins",
                [Symbol.Two] = "zwei",
                [Symbol.Three] = "drei",
                [Symbol.Four] = "vier",
                [Symbol.Five] = "fünf",
                [Symbol.Six] = "sechs",
                [Symbol.Seven] = "sieben",
                [Symbol.Eight] = "acht",
                [Symbol.Nine] = "neun",
                [Symbol.Minus] = "minus",
                [Symbol.Plus] = "plus",
                [Symbol.Point] = "punkt",
                [Symbol.Comma] = "komma",
                [Symbol.Exponent] = "exponent",
                [Symbol.Epsilon] = "epsilon",
                [Symbol.NegativeInfinity] = "negative unendlichkeit",
                [Symbol.PositiveInfinity] = "positive unendlichkeit",
                [Symbol.NaN] = "keine zahl",
            };
        }

        [TestCase(123.78, ExpectedResult = "один два три запятая семь восемь")]
        [TestCase(-12.78, ExpectedResult = "минус один два запятая семь восемь")]
        [TestCase(-0.78, ExpectedResult = "минус ноль запятая семь восемь")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "положительная бесконечность")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "отрицательная бесконечность")]
        [TestCase(double.NaN, ExpectedResult = "не число")]
        [TestCase(double.Epsilon, ExpectedResult = "эпсилон")]
        [TestCase(
            double.MinValue,
            ExpectedResult = "минус один запятая семь девять семь шесть девять три один три четыре восемь шесть два три один пять семь экспонента плюс три ноль восемь")]
        [TestCase(
            double.MaxValue,
            ExpectedResult = "один запятая семь девять семь шесть девять три один три четыре восемь шесть два три один пять семь экспонента плюс три ноль восемь")]
        [TestCase(6.67300E-11, ExpectedResult = "шесть запятая шесть семь три экспонента минус один один")]
        [TestCase(3.302e+23, ExpectedResult = "три запятая три ноль два экспонента плюс два три")]
        [TestCase(1234567890, ExpectedResult = "один два три четыре пять шесть семь восемь девять ноль")]
        public string TransformToWordsTestsWithRussianCulture(double number)
        {
            var russiandictionary = new SymbolsDictionary() { Dictionary = this.russianDictionary, CultureName = "ru-ru" };
            var transformer = new TransformerDictionaryAggregation.Transformer(russiandictionary);
            transformer.Transform(number);

            return transformer.Transform(number);
        }

        [TestCase(123.78, ExpectedResult = "one two three point seven eight")]
        [TestCase(-12.78, ExpectedResult = "minus one two point seven eight")]
        [TestCase(-0.78, ExpectedResult = "minus zero point seven eight")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "positive infinity")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "negative infinity")]
        [TestCase(double.NaN, ExpectedResult = "not a number")]
        [TestCase(double.Epsilon, ExpectedResult = "epsilon")]
        [TestCase(
            double.MinValue,
            ExpectedResult = "minus one point seven nine seven six nine three one three four eight six two three one five seven exponent plus three zero eight")]
        [TestCase(
            double.MaxValue,
            ExpectedResult = "one point seven nine seven six nine three one three four eight six two three one five seven exponent plus three zero eight")]
        [TestCase(6.67300E-11, ExpectedResult = "six point six seven three exponent minus one one")]
        [TestCase(3.302e+23, ExpectedResult = "three point three zero two exponent plus two three")]
        [TestCase(1234567890, ExpectedResult = "one two three four five six seven eight nine zero")]
        public string TransformToWordsTestsWithEnglishCulture(double number)
        {
            var dictionary = new SymbolsDictionary() { Dictionary = this.englishDictionary, CultureName = "en-us" };
            var transformer = new TransformerDictionaryAggregation.Transformer(dictionary);
            transformer.Transform(number);

            return transformer.Transform(number);
        }

        [TestCase(123.78, ExpectedResult = "eins zwei drei komma sieben acht")]
        [TestCase(-12.78, ExpectedResult = "minus eins zwei komma sieben acht")]
        [TestCase(-0.78, ExpectedResult = "minus null komma sieben acht")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "positive unendlichkeit")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "negative unendlichkeit")]
        [TestCase(double.NaN, ExpectedResult = "keine zahl")]
        [TestCase(double.Epsilon, ExpectedResult = "epsilon")]
        [TestCase(
            double.MinValue,
            ExpectedResult = "minus eins komma sieben neun sieben sechs neun drei eins drei vier acht sechs zwei drei eins fünf sieben exponent plus drei null acht")]
        [TestCase(
            double.MaxValue,
            ExpectedResult = "eins komma sieben neun sieben sechs neun drei eins drei vier acht sechs zwei drei eins fünf sieben exponent plus drei null acht")]
        [TestCase(6.67300E-11, ExpectedResult = "sechs komma sechs sieben drei exponent minus eins eins")]
        [TestCase(3.302e+23, ExpectedResult = "drei komma drei null zwei exponent plus zwei drei")]
        [TestCase(1234567890, ExpectedResult = "eins zwei drei vier fünf sechs sieben acht neun null")]
        public string TransformToWordsTestsWithGermanCulture(double number)
        {
            var dictionary = new SymbolsDictionary() { Dictionary = this.germanDictionary, CultureName = "de-de" };
            var transformer = new TransformerDictionaryAggregation.Transformer(dictionary);
            transformer.Transform(number);

            return transformer.Transform(number);
        }

        [Test]
        public void TransformToWords_DictionaryIsEmpty_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(
                () =>
                    new TransformerDictionaryAggregation.Transformer(new SymbolsDictionary()
                    {
                        Dictionary = new Dictionary<Symbol, string>(),
                        CultureName = null,
                    }),
                "Dictionary cannot be empty.");
        }

        [Test]
        public void TransformToWords_DictionaryIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => new TransformerDictionaryAggregation.Transformer(null),
                "Dictionary cannot be null.");
        }
    }
}
