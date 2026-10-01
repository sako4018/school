namespace Bank_system;

class Program
{    
    static void Main(string[] args)
    {
        Console.WriteLine("--- Welcome to the Bank System! ---");
        Console.WriteLine("Please enter your name or create a new bank account.");
        string name = Console.ReadLine();
        if name == BankAccount.Owner
        {
            Console.WriteLine($"Welcome back, {name}!");
        }
        else
        {
            Console.WriteLine($"Hello, {name}! Let's create a new bank account for you.");
            BankAccount account = new BankAccount(name);
            Console.WriteLine($"Bank account created for {account.Owner} with initial balance of {account.Balance}.");
        }
        BankAccount account = new BankAccount();
        Console.WriteLine("Enter the account owner: ");
        string owner = Console.ReadLine();
        account = new BankAccount(owner);

    }
}
/*Ниво 1: Основа (клас и капсулация)

Създай клас BankAccount със:
- Полета (private): owner (име на собственика), balance (баланс), accountNumber (номер на сметка)
- Конструктор: приема собственик и начален баланс (по подразбиране 0)
- Методи:
  - deposit(amount): внася пари
  - withdraw(amount): тегли пари
  - getBalance(): връща баланса
  - printInfo(): печата информация за сметката

Правила:
- Не може да се внася или тегли сума ≤ 0.
- Не може да се тегли повече, отколкото има в сметката.
- Балансът не може да се променя директно отвън, а само чрез методи.

Ниво 2: История на транзакциите

- Добави списък с всички операции (тип, сума, дата).
- Метод printHistory(), който ги показва.
- Създай отделен клас Transaction с полета type, amount, date.

Ниво 3: Банка с много сметки

Създай клас Bank, който:
- пази списък от сметки
- има createAccount(owner, initialBalance)
- има findAccount(accountNumber)
- има transfer(fromAccount, toAccount, amount): превод между две сметки

Ниво 4: Наследяване

От BankAccount наследи:
- SavingsAccount (спестовна): има лихва и метод addInterest(). Тегленето е ограничено до N пъти на месец.
- CheckingAccount (разплащателна): позволява овърдрафт (отива до определен минус).

Презапиши метода withdraw() във всеки от тях по свой начин. Това е полиморфизъм.

Бонус

- Хвърляй собствени изключения (InsufficientFundsException).
- Запис на сметките във файл.
- Прост текстов Меню (1. Внеси, 2. Тегли, 3. Баланс, 0. Изход).

Примерен тест

acc = BankAccount("Иван", 100)
acc.deposit(50)      # баланс 150
acc.withdraw(30)     # баланс 120
acc.withdraw(500)    # грешка: недостатъчна наличност
acc.deposit(-10)     # грешка: невалидна сума

Съвети

1. Направи Ниво 1 изцяло, преди да минеш на следващото.
2. Тествай всеки метод с граничните случаи (0, отрицателно число, точно целия баланс).
3. След всяко ниво се запитай: "Мога ли да променя баланса, без да минавам през метод?" Ако да, капсулацията не е добра.

Кажи ми на кой език ще го пишеш и къде да създам проекта, ако искаш да ти направя стартов шаблон.
*/