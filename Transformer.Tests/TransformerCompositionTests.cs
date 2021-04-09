using System.Globalization;
using System.Threading;
using EnglishDictionaryProvider;
using Moq;
using NUnit.Framework;
using ResourcesDictionaryProvider;
using TransformerDictionaryComposition;

namespace Transformer.Tests
{
    public class TransformerCompositionTests
    {
        private Mock<ISymbolsDictionaryProvider> mock;

        [OneTimeSetUp]
        public void SetUp()
        {
            mock = new Mock<ISymbolsDictionaryProvider>();
        }

        [Test]
        public void CreateDictionaryWorksOnceTime()
        {
            mock.Setup(provider => provider.CreateSymbolsDictionary())
                .Returns(() => new EnglishSymbolsDictionaryProvider().CreateSymbolsDictionary());

            ISymbolsDictionaryProvider symbolsDictionaryProvider = mock.Object;

            var transformer = new TransformerDictionaryComposition.Transformer(symbolsDictionaryProvider);

            transformer.Transform(123.78);

            mock.Verify(provider => provider.CreateSymbolsDictionary(), Times.Once());
        }

        [TestCase(123.78, "en-us", ExpectedResult = "one two three point seven eight")]
        [TestCase(-12.78, "en-us", ExpectedResult = "minus one two point seven eight")]
        [TestCase(-0.78, "en-us", ExpectedResult = "minus zero point seven eight")]
        [TestCase(123.78, "ru-ru", ExpectedResult = "один два три запятая семь восемь")]
        [TestCase(-12.78, "ru-ru", ExpectedResult = "минус один два запятая семь восемь")]
        [TestCase(-0.78, "ru-ru", ExpectedResult = "минус ноль запятая семь восемь")]
        [TestCase(double.PositiveInfinity, "en-us", ExpectedResult = "positive infinity")]
        [TestCase(double.PositiveInfinity, "ru-ru", ExpectedResult = "положительная бесконечность")]
        [TestCase(double.NegativeInfinity, "en-us", ExpectedResult = "negative infinity")]
        [TestCase(double.NegativeInfinity, "ru-ru", ExpectedResult = "отрицательная бесконечность")]
        [TestCase(double.NaN, "en-us", ExpectedResult = "not a number")]
        [TestCase(double.NaN, "ru-ru", ExpectedResult = "не число")]
        [TestCase(double.Epsilon, "en-us", ExpectedResult = "epsilon")]
        [TestCase(double.Epsilon, "ru-ru", ExpectedResult = "эпсилон")]
        public string TransformToWordsTestsWithResourcesFiles(double number, string cultureName)
        {
            mock.Setup(provider => provider.CreateSymbolsDictionary())
                .Returns(() => new ResourceSymbolsDictionaryProvider(cultureName).CreateSymbolsDictionary());

            ISymbolsDictionaryProvider symbolsDictionaryProvider = mock.Object;

            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);

            TransformerDictionaryComposition.Transformer transformer = new TransformerDictionaryComposition.Transformer(symbolsDictionaryProvider);

            return transformer.Transform(number);
        }
    }
}