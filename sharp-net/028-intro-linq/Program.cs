#region Code
// List<int> ints = new();
// 
// for (int i = 0; i < 10; i++)
// {
    // ints.Add(Random.Shared.Next(0, 10));
// }
// 
// List<int> evens = new();
// 
// 
// for (int i = 0; i < ints.Count; i++)
// {
    // if (ints[i] % 2 == 0)
    // {
        // evens.Add(ints[i]);
    // }
// }
// 
// 
// System.Console.WriteLine(String.Join(", ", ints));
// System.Console.WriteLine(String.Join(", ", evens));
#endregion

// using System.Linq;

int GetRandom(int item)
{
    return Random.Shared.Next(10);
}

bool Check(int item)
{
    return item % 2 == 0;
}

List<int> ints = Enumerable.Range(0, 10)
// .Select(item => Random.Shared.Next(10))
.Select(GetRandom)
.Select(e => e * 2)
// .Where(item => item % 2 == 0 && item > 0)
.Where(Check)
.OrderBy(e => e)
.ToList();

Console.WriteLine($"{ints.Count}");
Console.WriteLine($"{String.Join(",", ints)}");