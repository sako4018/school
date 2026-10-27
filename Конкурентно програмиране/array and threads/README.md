# ArrayAndThreads

Конзолно приложение на C# (.NET 8) за задачата „Масиви и нишки“ по Конкурентно програмиране.

## Как се пуска

```bash
cd ~/"Desktop/Developer/училище/Конкурентно програмиране/array and threads"
dotnet run
```

## Какво прави

Масивът `{ 4, 7, 2, 9, 6 }` се обработва от масив от 5 нишки (`Thread[]`):

- нишки 1 и 2 → `PrintNumbers()` – извежда всички числа;
- нишки 3 и 4 → `FindEvenNumbers()` – извежда четните числа;
- нишка 5 → `SumEvenNumbers()` – извежда сумата на четните числа.

## Примерен изход

```
All numbers: 4 7 2 9 6 
Even numbers: 4 2 6 
All numbers: 4 7 2 9 6 
Even numbers: 4 2 6 
Sum of even numbers: 12
```

Редът на редовете е различен при всяко пускане, защото нишките работят едновременно.

## Структура

```
array and threads/
├── ArrayAndThreads.csproj   // настройки на проекта (net8.0, Exe)
├── Program.cs               // входна точка: клас Program с метод Main
└── README.md
```
