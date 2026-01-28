string exit = "";
while (exit != "exit")
{
    Console.WriteLine($"--------------------------------------------------------------------");
    Console.WriteLine("Добро пожаловать!");
    Console.Write("Введите общую сумму счета: ");
    decimal amount = GetValueStringToInt();
    Console.Write("Введите процент чаевых (в процентах): ");
    decimal percentTip = GetValueStringToInt();
    Console.Write("Колличество человек в группе: ");
    decimal personCount = GetValueStringToInt();


    decimal amountTip = AmountTip(amount, percentTip);
    decimal totalAmount = TotalAmount(amount, amountTip);
    decimal amountPerPerson = AmountPerPerson(totalAmount, personCount);

    Console.WriteLine($"--------------------------------------------------------------------");
    Console.WriteLine($"Общий счет: {totalAmount}");
    Console.WriteLine($"Процент чаевых: {percentTip}%, сумма чаевых: {amountTip}");
    Console.WriteLine($"С каждого: {amountPerPerson}");
    Console.WriteLine($"--------------------------------------------------------------------");

    Console.WriteLine($"Для завершения работы рограммы введите -> exit");
    exit = Console.ReadLine();

    static decimal AmountTip(decimal amount, decimal percentTip)
    {
        return (amount * percentTip) / 100m;
    }

    static decimal TotalAmount(decimal amount, decimal amountTip)
    {
        return amount + amountTip;
    }

    static decimal AmountPerPerson(decimal totalAmount, decimal personCount)
    {
        return totalAmount / personCount;
    }

    static decimal GetValueStringToInt()
    {
        decimal result;

        while (!decimal.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.WriteLine("Ожидаем число больше 0");
        }

        return result;
    }
}