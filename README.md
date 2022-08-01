# Transformer. Composition vs Aggregation. (in progress)

Intermediate level task for practicing inheritance, interfaces, composition, aggregation, Factory Method design pattern, resources files.

Estimated time to complete the task - 4h.

The task requires .NET 6 SDK installed.

## Task description

Develop a type system that allows you to convert real number to its string representations in any given language.

- Review the articles
    - [Difference between Composition and Aggregation](https://www.c-sharpcorner.com/article/difference-between-composition-and-aggregation/)
    - [Aggregation Vs Composition: A Simple Practical Approach](https://www.c-sharpcorner.com/UploadFile/97fc7a/aggregation-vs-composition-a-simple-practical-approach/)
    - [Factory Method](https://refactoring.guru/design-patterns/factory-method)
    - [Resources files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically)
- Implement the following two scenarios to solve the  task above.
- Discuss defference between composition and aggregation with your trainer, if you work in a regular group.

### Composition Dictionary Scenario

- Implement [Transformer](TransformerDictionaryComposition/Transformer) class that converts real number to its "word format" in any given language. String presentation depend on the language and the set of words that are presented by a `СharactersDictionary` class. The `Transformer` class _controls the creation time_ of an `CharsDictionary` class object (`CharsDictionary` composition).

    - [Сharacter](TransformerDictionaryComposition/Сharacter) enum - an enumeration containing a set of words for all characters that a real number can contain.
    - [CharsDictionary](TransformerDictionaryComposition/CharsDictionary) class - presents the dictionary of correspondences of the number characters to their word analogs in given language. 
    - [ICharsDictionaryProvider](TransformerDictionaryComposition/ICharsDictionaryProvider) interface - presents the provider of the dictionary of dictionary of correspondences of characters to their word analogs in given language.

- Implement [EnglishCharsDictionaryProvider](GermanDictionaryProvider/EnglishCharsDictionaryProvider) class that presents the dictionary of correspondences of the number characters to their word analogs in german.

- Implement [GermanCharsDictionaryProvider](EnglishDictionaryProvider/GermanCharsDictionaryProvider) class that presents the dictionary of correspondences of the number characters to their word analogs in english.

- Implement [RussianCharsDictionaryProvider](RussianDictionaryProvider/RussianCharsDictionaryProvider) class that presents the dictionary of correspondences of the number characters to their word analogs in russian.

- Implement [ResourceCharsDictionaryProvider](ResourcesDictionaryProvider/ResourceCharsDictionaryProvider) class that presents the dictionary of correspondences of the number characters to their word analogs in several languages (english, german, russian). To support several languages use [resources files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically). Add files to [Resources](ResourcesDictionaryProvider/Resources) folder if it necessary.

- Run [unit и mock tests]((/Transformer.Tests/TransformerCompositionTests.cs).)

### Aggregation Dictionary Scenario

- Implement [Transformer](/TransformerDictionaryAggregarion/Transformer.cs#L6[](url)) class, whose `Transform` instance method converts real number to it's "word format" in some language. The language and the set of words are presented by a settings class wich is passed in `Transformer` class from outside.

- Add [new unit tests](/Transformer.Tests/TransformerAggregationTests.cs).

