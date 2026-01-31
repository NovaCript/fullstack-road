Random _rand = new Random();

List<int> list = GenerateRandomList(5, 11, 25);
Console.WriteLine($"{ConsoleWriteList(list)}");
Console.WriteLine($"{GetSumElementGreater10(list)}");


List<int> GenerateRandomList(int minN, int maxN, int maxValue)
{
    List<int> list = new();
    int count = _rand.Next(minN, maxN + 1);
    for (int i = 0; i < count; i++)
    {
        list.Add(_rand.Next(maxValue));
    }
    return list;
}

string ConsoleWriteList(List<int> list)
{
    return $"[{string.Join(", ", list)}]";
}

int GetSumElementGreater10(List<int> list)
{
    int result = 0;
    foreach (var item in list)
    {
        if (IsTwoDigit(item))
        {
            result += item;
        }
    }
    return result;
}

bool IsTwoDigit(int value)
{
    return value > 9 && value < 100;
}