# Shop

Конзолно приложение с MVC (.NET 8) за задачата „Магазин“ (shop-02.12).

Програмата чете продукт, град и количество (всяко на отделен ред) и показва цената: единична цена * количество.

| Град | coffee | water | juice | sweets | peanuts |
| --- | --- | --- | --- | --- | --- |
| Sofia | 0.50 | 0.80 | 1.20 | 1.45 | 1.60 |
| Plovdiv | 0.40 | 0.70 | 1.15 | 1.30 | 1.50 |
| Varna | 0.45 | 0.70 | 1.10 | 1.35 | 1.55 |

При непознат продукт или град, или при отрицателно количество, се показва `Invalid input!`.

## Как се пуска

```bash
cd "shop-02.12/Shop"
dotnet run
```

## Пример

| Вход | Изход |
| --- | --- |
| coffee, Varna, 2 | 0.9 |
| peanuts, Plovdiv, 1 | 1.5 |
| juice, Sofia, 6 | 7.2 |
| water, Plovdiv, 3 | 2.1 |
| sweets, Sofia, 2.23 | 3.2335 |
| tea, Sofia, 2 | Invalid input! |

## Структура

- `Shop/Models/Model.cs` – данните, проверката (`IsValid`), цените (`Prices`) и сметката (`Calculate`)
- `Shop/Views/View.cs` – чете от конзолата (`GetValues`) и показва резултата (`ShowVal`, `ShowError`)
- `Shop/Controllers/Controller.cs` – `Run()` свързва View и Model
- `Shop/Program.cs` – пуска Controller
