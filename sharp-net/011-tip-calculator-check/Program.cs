Console.Write($"Введите сумму счета: ");
double billAmount;
if (!double.TryParse(Console.ReadLine(), out billAmount) || billAmount <= 0)
{
    Console.WriteLine($"Ошибка ввода");
}

Console.Write($"Введите процент чаевых: ");
double tipPersent;
if(!double.TryParse(Console.ReadLine(), out tipPersent) || tipPersent < 0)
{
    Console.WriteLine($"Ошибка ввода");
}

Console.Write($"Введите колличество человек: ");
int countPerson;
if (!int.TryParse(Console.ReadLine(), out countPerson) || countPerson <= 0)
{
    Console.WriteLine($"Ошибка ввода. Должен быть хотя бы один человек");
}


double tipAmount = billAmount * tipPersent / 100;
double totalAmount = billAmount + tipAmount;
double amountPerPerson = totalAmount / countPerson;

Console.WriteLine($"Общий счет: {totalAmount}");
Console.WriteLine($"Прочент чаевых: {tipPersent}%, сумма чаевых {tipAmount}");
Console.WriteLine($"Сумма на человека: {amountPerPerson}");