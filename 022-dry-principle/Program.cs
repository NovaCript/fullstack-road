using System;
using System.Text;


Random _rand = new Random();


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
    return $"List: [{string.Join(", ", list)}]";
}

int GetSumElement(List<int> list, Func<int, bool> predicate)
{
    return list.Where(predicate).Sum();
}

bool IsTwoDigit(int value)
{
    return value > 9 && value < 100;
}


List<int> list = GenerateRandomList(5, 11, 25);
Console.WriteLine($"{ListToString(list)}");
Console.WriteLine($"Sum: {GetSumElement(list, IsTwoDigit)}");

StringBuilder sb = new StringBuilder();
sb.Append(ListToString(list));
sb.Append($"Sum: {GetSumElement(list, IsTwoDigit)}");


File.WriteAllText("file.txt", sb.ToString());