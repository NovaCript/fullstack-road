// тип данных[] имя переменной;
// имя переменной = new тип нанных[количество элементов];

int[] myArray = { 1, 2, 3, 4, 5 };

int[] myArray2 = new int[5];

int[] myArray3 = new int[5] { 2, 1, 77, 22, 221 };

for (int i = 0; i < myArray2.Length; i++)
{
    myArray2[i] = i;
    Console.Write($"[{myArray2[i]}]");
}
Console.WriteLine($"");

Console.WriteLine($"{String.Join(", ", myArray)}");

Array.Resize(ref myArray3, 100);
Console.WriteLine($"{myArray3.Length}");

Array.Resize(ref myArray3, 5);
Array.Sort(myArray3);
Console.WriteLine($"{String.Join(", ", myArray3)}");

Array.Reverse(myArray3);
Console.WriteLine($"{String.Join(", ", myArray3)}");

// ===============================================================

int[,] multiDimensionalArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
{
    Console.Write($"[");
    for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
    {
        Console.Write($"[{multiDimensionalArray[i,j]}]");
    }
    Console.WriteLine($"]");
}