# Transformer. Composition vs Aggregation. (in progress)

## Task Description

Develop a type system that allows you to convert real numbers to their string representations in any given language.

### Composition Dictionary Scenario

#### Types
- [Symbol](TransformerDictionaryComposition/Sympol) enum - an enumeration containing a set of words for all characters that a real number can contain.
- [ISymbolsDictionaryProvider](TransformerDictionaryComposition/ISymbolsDictionaryProvider) interface - presents the provider of the dictionary of dictionary of correspondences of symbols to their word analogs in given language.

- Implement [Transformer](/TransformerDictionaryComposition/Transformer.cs#L5) class, whose `Transform` instance method converts real number to it's "word format" in some language. The language and the set of words are presented by a settings class. However, the `Transformer` class controls the creation time of an object of this class.
- Add [new unit и mock tests](/Transformer.Tests/TransformerCompositionTests.cs).
- Use ability [resources files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically) to test `Transformer` class with various languages (russian, english, german). 

### Aggregation Dictionary Scenario

#### Types

- Implement [Transformer](/TransformerDictionaryAggregarion/Transformer.cs#L6[](url)) class, whose `Transform` instance method converts real number to it's "word format" in some language. The language and the set of words are presented by a settings class wich is passed in `Transformer` class from outside.
- Add [new unit tests](/Transformer.Tests/TransformerAggregationTests.cs).
