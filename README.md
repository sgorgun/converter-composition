# Transformer. Composition vs Aggregation. (in progress)

Intermediate level task for practicing inheritance, interfaces, composition, aggregation, Factory Method design pattern, resources files, mock tests.

Estimated time to complete the task - 4h.

The task requires .NET 6 SDK installed.

## Task description

Solve the converting problem of the real number to its "in words" string representations in any given language. 

- Review the articles
    - [Difference between Composition and Aggregation](https://www.c-sharpcorner.com/article/difference-between-composition-and-aggregation/)
    - [Aggregation Vs Composition: A Simple Practical Approach](https://www.c-sharpcorner.com/UploadFile/97fc7a/aggregation-vs-composition-a-simple-practical-approach/)
    - [Factory Method](https://refactoring.guru/design-patterns/factory-method)
    - [Resources files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically)

- _Discuss defference between composition and aggregation with your trainer, if you work in a regular group._

- Implement the following two scenarios to solve the task above.

### Aggregation Dictionary Scenario

- Implement [Transformer](TransformerDictionaryAggregarion/Transformer) class whose `Transform` instance method converts real number to its "in words" string representations in any given language.     
    **Requirement**: The `Transform` method of the `Transformer` class uses the object of the `CharsDictionary` class, that is passed from outside as a mandatory dependency.

- Implement [EnglishCharsDictionaryFactory](GermanDictionaryFactory/EnglishCharsDictionaryFactory) class that presents the dictionary of correspondences of the number characters to their word analogs in german.

- Implement [GermanCharsDictionaryFactory](EnglishDictionaryFactory/GermanCharsDictionaryFactory) class that presents the dictionary of correspondences of the number characters to their word analogs in english.

- Implement [RussianCharsDictionaryFactory](RussianDictionaryFactory/RussianCharsDictionaryFactory) class that presents the dictionary of correspondences of the number characters to their word analogs in russian.

- Add [new unit tests](/Transformer.Tests/TransformerAggregationTests.cs).

### Composition Dictionary Scenario

- Implement [Transformer](TransformerDictionaryComposition/Transformer) class whose `Transform` instance method converts real number to its "in words" string representations in any given language.     
    **Requirement**: The `Transformer` should be manage the lifetime of the object (composition) of the `Charts Dictionary` class, but do it with an additional abstraction, the factory class.   
    Use for the solution following tyype sytem:
    - [Сharacter](TransformerDictionaryComposition/Сharacter) enum - an enumeration consists of a set of words for all characters that a real number can contains.
    - [CharsDictionary](TransformerDictionaryComposition/CharsDictionary) class - presents the dictionary of correspondences of the number characters to their word analogs in given language. 
    - [ICharsDictionaryFactory](TransformerDictionaryComposition/ICharsDictionaryFactory) interface - presents the factory of the dictionary of dictionary of correspondences of characters to their word analogs in given language.

- Implement [ResourceCharsDictionaryFactory](ResourcesDictionaryFactory/ResourceCharsDictionaryFactory) class that presents the dictionary of correspondences of the number characters to their word analogs in several languages (english, german, russian). 
    - To support several languages use [resources files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically).
    - Study generated code of the [Dictionary.Designer] file(ResourcesDictionaryFactory/Resources/Dictionary.Designer.cs).
    - Add resources files to [Resources](ResourcesDictionaryFactory/Resources) folder if it necessary.
    - Fill the contents of the resource files according to the specific language.

- Run [unit и mock tests](TransformerCompositionAndAggregation.Tests/TransformerDictionaryComposition)
