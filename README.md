# Converter. Composition vs Aggregation. (in progress)

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

- Implement the following two scenarios to solve the task above.


<details>
<summary>

Aggregation Dictionary Scenario

</summary>

- Implement [Converter](ConverterDictionaryAggregation/Converter.cs) class whose `Convert` method converts real number to its "in words" string representations in any given language.     
    **Requirement**: The `Convert` method of the `Converter` class uses the object of the `CharsDictionary` class, that is passed from outside as a mandatory dependency.

- Implement [EnglishCharsDictionaryFactory](EnglishDictionaryFactory/EnglishCharsDictionaryFactory.cs) class that presents the dictionary of chars correspondences of the number to their word analogs in german.

- Implement [GermanCharsDictionaryFactory](GermanDictionaryFactory/GermanCharsDictionaryFactory.cs) class that presents the dictionary of chars correspondences of the number to their word analogs in english.

- Implement [RussianCharsDictionaryFactory](RussianDictionaryFactory/RussianCharsDictionaryFactory.cs) class that presents the dictionary of chars correspondences of the number to their word analogs in russian.

- Run [unit tests](ConverterCompositionAndAggregation.Tests.TransformerDictionaryComposition/ConverterAggregationTests.cs).
</details>

<details>
<summary>

Composition Dictionary Scenario

</summary> 

1. Implement [Converter](ConverterDictionaryComposition/Converter.cs) class whose `Convert` method converts real number to its "in words" string representation in any given language.     
    **Requirement**: The `Converter` class should be manage the lifetime of the `Charts Dictionary` class object, but do it with an additional abstraction, the factory class.   
    Use for the solution following type system:
    - [Сharacter](ConverterDictionaryComposition/Сharacter.cs) enum consists of a set of words for all characters that a real number can contains.
    - [CharsDictionary](ConverterDictionaryComposition/CharsDictionary.cs) class presents the dictionary of correspondences of the number characters to their word analogs in given language. 
    - [ICharsDictionaryFactory](ConverterDictionaryComposition/ICharsDictionaryFactory.cs) interface presents the factory of dictionary of the chars correspondences to their word analogs in given language.

1. Implement [ResourceCharsDictionaryFactory](ResourcesDictionaryFactory/ResourceCharsDictionaryFactory.cs) class that presents the dictionary of chars correspondences of the number to their word analogs in several languages (english, german, russian). 
    - To support several languages use [resources files](https://docs.microsoft.com/en-us/dotnet/core/extensions/work-with-resx-files-programmatically).
    - Study generated code of the [Dictionary.Designer](ResourcesDictionaryFactory/Resources/Dictionary.Designer.cs) file.
    - Add resources files to [Resources](ResourcesDictionaryFactory/Resources) folder if it necessary.
    - Fill the contents of the resource files according to the specific language.

1. Run [unit и mock tests](ConverterCompositionAndAggregation.Tests/TransformerDictionaryComposition/ConverterCompositionTests.cs)

</details>

- _Discuss following questions with your trainer, if you work in a regular group._   
    - What is defference between composition and aggregation?

