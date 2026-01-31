Random _rand = new Random();

List<int> list = GenerateRandomList(5, 11, 25);
Console.WriteLine($"{ListToString(list)}");
Console.WriteLine($"{GetSumElementTwoDigit(list)}");


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

string ListToString(List<int> list)
{
    return $"[{string.Join(", ", list)}]";
}

int GetSumElementTwoDigit(List<int> list)
{
    return list.Where(IsTwoDigit).Sum();
}

bool IsTwoDigit(int value)
{
    return value > 9 && value < 100;
}