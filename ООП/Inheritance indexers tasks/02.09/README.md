# Task_02_09

Конзолно приложение на C# (.NET 8) за задача 02.09 „ParkingMachine“: наследяване (ООП).

## Задание

`ParkingEntry` (номер, минути, цена), `ParkingMachine` със списък, `Count` и индексатор, и наследниците `ParkingMachineForCar` (3.00 лв./час) и `ParkingMachineForBus` (6.00 лв./час). Номерът е от 1000 до 4999, престоят е от 30 до 180 минути, а невалиден индекс хвърля `ArgumentOutOfRangeException`. В `Main` се генерират по три случайни записа във всеки автомат. Условието е в Classroom, „Задачки закачки“.

## Как се пуска

```bash
cd "$HOME/Desktop/Developer/училище/ООП/Inheritance indexers tasks/02.09"
dotnet run
```

## Структура

- `Task_02_09.csproj` – проектният файл (.NET 8, конзолно приложение)
- `Program.cs` – класовете и входната точка `Main`
