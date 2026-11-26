# Итератори - упражнение (ООП, 04.05)

Решения на 8-те задачи от упражнението "Итератори" (учебна редакция 04.05 и оригиналът от ИТ кариера).
Всяка задача е отделно конзолно приложение (`net8.0`).

## Как се пуска

```bash
cd "Task3_ListyIterator"
dotnet run
```

Задачи 3-8 четат входа от конзолата (както е в условието). Задачи 1 и 2 имат фиксиран пример в `Main`.

## Задачи

| Папка | Задача |
|---|---|
| `Task1_Library` | `Book` и `Library` с `params` |
| `Task2_LibraryIterator` | Ръчен итератор `LibraryIterator` (вложен клас) |
| `Task3_ListyIterator` | `ListyIterator<T>`: Create, Move, HasNext, Print |
| `Task4_Collection` | `ListyIterator<T>` като `IEnumerable<T>` (`yield return`) и `PrintAll` |
| `Task5_Stack` | Собствен `Stack<T>` с обхождане от върха към дъното |
| `Task6_Frog` | "Жабче": `Lake`, четни индекси нагоре, нечетни надолу |
| `Task7_PetClinic` | Клиника за домашни любимци (допълнителна задача) |
| `Task8_LinkedList` | Собствен свързан списък `LinkedList<T>` (допълнителна задача) |

## Бележки

- Следва се учебната редакция: `Book.Authors` е `List<string>`, а курсорът на `LibraryIterator` започва от -1.
- В задача 7 командата `Create Pet` не печата нищо, а грешките се печатат като `Invalid Operation!`.
