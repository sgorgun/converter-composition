# Transformer. Composition vs Aggregation.

## Task Description

Develop a types system that allows you to convert a real array to an array of strings. For each array element, the string representation is a "word format" in some given language.

### Composition Dictionary Scenario

#### Types
- [Symbol](TransformerDictionaryComposition/Sympol) enum- an enum that contains values for all possible characters in the real number representation.
- [ISymbolsDictionaryProvider](TransformerDictionaryComposition/ISymbolsDictionaryProvider) interface 



    - Implement [Transformer](/TransformerDictionaryComposition/Transformer.cs#L5) class, whose `Transform` instance method converts real number to it's "word format" in some language. The language and the set of words are presented by a settings class. However, the `Transformer` class controls the creation time of an object of this class.
    - Add [new unit и mock tests](/Transformer.Tests/TransformerCompositionTests.cs).
    - Use ability [resources files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically) to test `Transformer` class with various languages (russian, english, german). 

### Aggregation Dictionary Scenario

    - Implement [Transformer](/TransformerDictionaryAggregarion/Transformer.cs#L6[](url)) class, whose `Transform` instance method converts real number to it's "word format" in some language. The language and the set of words are presented by a settings class wich is passed in `Transformer` class from outside.
    - Add [new unit tests](/Transformer.Tests/TransformerAggregationTests.cs).
