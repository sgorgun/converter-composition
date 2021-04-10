# Transformer. Interfaces

## Task Description

- 1.
    - Реализовать класс [Transformer](/TransformerDictionaryAggregarion/Transformer.cs#L6[](url)), экземплярный метод `Transform` которого выполняет преобразование вещественного чисела в его "словесный формат", при этом язык получения "словесного формата" в форме словаря является параметром настройки класса и передается извне.
    - Добавить [новые unit тесты](/Transformer.Tests/TransformerAggregationTests.cs).
- 2.
    - Реализовать класс [Transformer](/TransformerDictionaryComposition/Transformer.cs#L5), экземплярный метод `Transform` которого выполняет преобразование вещественного чисела в его "словесный формат", при этом язык получения "словесного формата" в форме словаря является параметром настройки метода, однако время его создания определяет сам класс `Transformer`.
    - Добавить [новые unit и mock тесты](/Transformer.Tests/TransformerCompositionTests.cs).
    - При [тестировании](/Transformer.Tests/TransformerCompositionTests.cs) работы класса [Transformer](/TransformerDictionaryComposition/Transformer.cs#L5) с различными языками (русский, английский, немецкий) использовать возможности [файлы ресурсов](/ResourcesDictionaryProvider/Resources) (resx-файлы).
