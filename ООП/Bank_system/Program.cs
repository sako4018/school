namespace Bank_system;

class Program
{    
    static List<BankAccount> accounts = new List<BankAccount>();
    static void Main(string[] args)
    {
        Console.WriteLine("--- Welcome to the Bank System! ---");
        Console.WriteLine("1. Create Account");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Check Balance");
        Console.WriteLine("5. Print Account Info");

        Console.WriteLine("Enter your choice (1-5): ");
        int choice = int.Parse(Console.ReadLine());

        if(choice == 1)
        {
            BankAccount newAccount = new BankAccount();
        }
        else if(choice == 2)
        {
            
        }
        else if(choice == 3)
        {
            
        }
        else if(choice == 4)
        {
            
        }
        else if(choice == 5)
        {
            
        }
        else
        {
            Console.WriteLine("Invalid choice.");
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