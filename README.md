# Transformer. Interfaces

## Task Description

- 1.
    - Implement [Transformer](/TransformerDictionaryAggregarion/Transformer.cs#L6[](url)) class, whose `Transform` instance method converts real number to it's "word format" in some language. The language and the set of words are presented by a settings class wich is passed in `Transformer` class from outside.
    - Add [new unit tests](/Transformer.Tests/TransformerAggregationTests.cs).
- 2.
    - Implement [Transformer](/TransformerDictionaryComposition/Transformer.cs#L5) class, whose `Transform` instance method converts real number to it's "word format" in some language. The language and the set of words are presented by a settings class. However, the `Transformer` class controls the creation time of an object of this class.
    - Add [new unit и mock tests](/Transformer.Tests/TransformerCompositionTests.cs).
    - Use ability [Resources files](/ResourcesDictionaryProvider/Resources) (see [.resx files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically)) when [testing](/Transformer.Tests/TransformerCompositionTests.cs) work [Transformer](/TransformerDictionaryComposition/Transformer.cs#L5) class with various languages (russian, english, german). 
