int a = 5, b = 5;
Console.WriteLine($"{a} равно {b}: {a == b}");

int c = 5, d = 3;
Console.WriteLine($"{c} не равно {d}: {c != d}");


bool res = (a > b) && (c < d);
Console.WriteLine($"{res}");

res = (a > b) || (c > d);
Console.WriteLine($"{res}");


// Пример использования логического исключающее ИЛИ (XOR)
bool m = true, n = false;
Console.WriteLine($"Только одно из условий истинно: {m ^ n}");