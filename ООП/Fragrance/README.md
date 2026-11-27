# Fragrance

Конзолно приложение на C# (.NET 8) за задача 03.02 „Fragrance“: шаблонни типове (ООП).

## Задание

- Интерфейс `IFragrance` с `GetAroma()` и `GetLongevity()` (1 до 24 часа).
- Абстрактен клас `Perfume` с `Brand`, `Name`, `Price`, `PrintInfo()` и абстрактен `GetCategory()`. Не допуска празни марка/име и отрицателна или некрайна цена.
- `EauDeParfum` с `OilPercentage` от 0 до 100: „Лек“ под 15, „Среден“ от 15 до 20, „Интензивен“ над 20.
- `EauDeToilette` с `IsLimitedEdition`: „Лимитирана серия“ или „Стандартен“.
- `PerfumeTester` реализира `IFragrance`, но не наследява `Perfume`. Има `Guid Id`, `Notes` и трайност от 1 до 3 часа.
- Демонстрация със `List<IFragrance>`, сортиране по трайност, филтър над 10 часа, средна цена на `EauDeParfum` и парфюм(и) с най-висок `OilPercentage`. Всичко е с цикли, без LINQ.

Условието е в Classroom, „task-fragrance“.

## Как се пуска

```bash
cd "$HOME/Desktop/Developer/училище/ООП/Fragrance"
dotnet run
```

## Структура

```
Fragrance/
├── Fragrance.csproj   # настройки на проекта (net8.0, Exe)
├── Program.cs         # интерфейсът, класовете и входната точка Main
└── README.md
```

Папките `bin/` и `obj/` се създават при build и не се качват в git.
