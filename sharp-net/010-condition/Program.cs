int month = 10;
IsOctober(month);

month = 9;
IsOctober(month);


int anotherNumber = 7;
string result = anotherNumber < 10 ? "Меньше 10" : "10 или больше";
Console.WriteLine($"{result}");

int temp = 15;
string resultValueTemp = temp switch
{
    1 => "Один",
    2 => "Два",
    3 => "Три",
    // "_" служит для обозначения всех остальных случаев
    _ => "Какое то  значение"
};

Console.WriteLine($"{resultValueTemp}");


void IsOctober(int monthValue)
{
    switch (month)
{
    case 10:
        Console.WriteLine($"Октябрь");
        break;
    default:
        Console.WriteLine($"Не октябрь");
        break;
}
}