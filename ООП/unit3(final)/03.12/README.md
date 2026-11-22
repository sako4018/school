# Task_03_12

Конзолно приложение на C# (.NET 8) за задача 03.12 „Обобщение - упражнение“ от unit 3: шаблонни типове (ООП).

## Задание

Интерфейси `IAnimal` и `IMammal`, класове `Snake`, `Lion`, `Bird` и `ConstrainByInterface<T>` с ограничение `where T : IAnimal`.

Програмата няма вход. Изход:

```text
Snake has got tail
Lion has got tail and baby_mammal
Bird has got beak
```

Пълното условие е в Classroom, „final tasks(unit 3)“.

## Как се пуска

```bash
cd "$HOME/Desktop/Developer/училище/ООП/unit3(final)/03.12"
dotnet run
```

## Структура

- `Task_03_12.csproj` – проектният файл (.NET 8, конзолно приложение)
- `Program.cs` – входна точка с метода `Main`
