using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using NUnit.Framework;
using Symbol = TransformerDictionaryAggregation.Symbol;

namespace Transformer.Tests
{
    public class TransformerAggregationTests
    {
        private IReadOnlyDictionary<Symbol, string> englishDictionary;
        private IReadOnlyDictionary<Symbol, string> russianDictionary;

        [OneTimeSetUp]
        public void SetUp()
        {
            englishDictionary = new Dictionary<Symbol, string>
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

            russianDictionary = new Dictionary<Symbol, string>
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
                [Symbol.NaN] = "не число"
            };
        }

        [TestCase(123.78, ExpectedResult = "один два три запятая семь восемь")]
        [TestCase(-12.78, ExpectedResult = "минус один два запятая семь восемь")]
        [TestCase(-0.78, ExpectedResult = "минус ноль запятая семь восемь")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "положительная бесконечность")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "отрицательная бесконечность")]
        [TestCase(double.NaN, ExpectedResult = "не число")]
        [TestCase(double.Epsilon, ExpectedResult = "эпсилон")]
        public string TransformToWordsTestsWithRussianCulture(double number)
        {
            var transformer = new TransformerDictionaryAggregation.Transformer(russianDictionary);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-ru");

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
        public string TransformToWordsTestsWithEnglishCulture(double number)
        {
            var transformer = new TransformerDictionaryAggregation.Transformer(englishDictionary);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");

            transformer.Transform(number);

            return transformer.Transform(number);
        }
    }
}