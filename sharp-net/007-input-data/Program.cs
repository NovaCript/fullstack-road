Console.Write("Введиде ваше имя: ");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");

Console.Write("Нажмите любую клавишу, чтобы продолжить...");
ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine($"\nВы нажали клавишу {keyInfo.KeyChar}");

Console.Write("Введите ваш возраст: ");
string inputAge = Console.ReadLine();

bool parseResult = int.TryParse(inputAge, out int age);
Console.WriteLine($"Получилось ли преобразовать: {parseResult}");
if (parseResult)
{
    Console.WriteLine($"Ваш возраст: {age} лет.");
}
else
{
    Console.WriteLine("Ввели не число");
}

// double dou = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"sds {parseResult}");

System.Console.WriteLine();