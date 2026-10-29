# OnTime

Конзолно приложение с MVC (.NET 8) за задачата „Навреме за изпит“ (ontime-02.07).

Програмата чете час и минута на изпита и час и минута на пристигане (4 цели числа, всяко на отделен ред) и показва дали студентът е подранил, пристигнал навреме или закъснял.

| Условие | Първи ред |
| --- | --- |
| Пристигане след началото | Late |
| Точно в началото или до 30 минути по-рано | On time |
| Повече от 30 минути по-рано | Early |

Ако разликата не е 0, има и втори ред: `mm minutes before/after the start` (под час) или `hh:mm hours before/after the start` (час или повече). При грешен час или минута се показва `Invalid input!`.

## Как се пуска

```bash
cd "ontime-02.07/OnTime"
dotnet run
```

## Пример

| Вход | Изход |
| --- | --- |
| 9, 30, 9, 50 | Late<br>20 minutes after the start |
| 9, 00, 8, 30 | On time<br>30 minutes before the start |
| 16, 00, 15, 00 | Early<br>1:00 hours before the start |
| 9, 00, 10, 30 | Late<br>1:30 hours after the start |
| 10, 00, 10, 00 | On time |

## Структура

- `OnTime/Models/Model.cs` – данните, проверката (`IsValid`) и сметката (`Calculate`)
- `OnTime/Views/View.cs` – чете от конзолата (`GetValues`) и показва резултата (`ShowVal`, `ShowError`)
- `OnTime/Controllers/Controller.cs` – `Run()` свързва View и Model
- `OnTime/Program.cs` – пуска Controller
