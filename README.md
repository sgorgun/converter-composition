# Transformer. Interfaces

## Task Description

- Реализовать класс [Transformer](https://gitlab.com/autocode-tasks/transformer-interfaces/-/blob/master/TransformerDictionaryAggregarion/Transformer.cs#L6[](url)), экземплярный метод `Transform` которого выполняет преобразование вещественного чисела в его "словесный формат", при этом язык получения "словесного формата" в форме словаря является параметром настройки класса и передается извне.
- Добавить [новые unit тесты](https://gitlab.com/autocode-tasks/transformer-interfaces/-/blob/master/Transformer.Tests/TransformerAggregationTests.cs).

- Реализовать класс [Transformer](https://gitlab.com/autocode-tasks/transformer-interfaces/-/blob/master/TransformerDictionaryComposition/Transformer.cs#L5), экземплярный метод `Transform` которого выполняет преобразование вещественного чисела в его "словесный формат", при этом язык получения "словесного формата" в форме словаря является параметром настройки метода, однако время его создания определяет сам класс `Transformer`.
- Добавить [новые unit и mock тесты](https://gitlab.com/autocode-tasks/transformer-interfaces/-/blob/master/Transformer.Tests/TransformerCompositionTests.cs).
- При [тестировании](https://gitlab.com/autocode-tasks/transformer-interfaces/-/blob/master/Transformer.Tests/TransformerCompositionTests.cs) работы класса [Transformer](https://gitlab.com/autocode-tasks/transformer-interfaces/-/blob/master/TransformerDictionaryComposition/Transformer.cs#L5) с различными языками (русский, английский, немецкий) использовать возможности [файлы ресурсов](https://gitlab.com/autocode-tasks/transformer-interfaces/-/tree/master/ResourcesDictionaryProvider/Resources) (resx-файлы).
