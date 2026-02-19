// Абсолютное значение
System.Console.WriteLine(Math.Abs(-5));
// Максимальное и минимальное
System.Console.WriteLine(Math.Max(5, -6));
System.Console.WriteLine(Math.Min(5, -6));
// Округление
System.Console.WriteLine(Math.Ceiling(2.5)); // до большего числа
System.Console.WriteLine(Math.Floor(2.8)); // до меньшего числа
System.Console.WriteLine(Math.Round(2.51)); // до ближайшего целого

// Тригонометрические функции
double angle = Math.PI / 4; // 45 градусов в радианах
System.Console.WriteLine(Math.Sin(angle));
System.Console.WriteLine(Math.Cos(angle));
System.Console.WriteLine(Math.Tan(angle));

// экспоненциальные и логарифмические функции
System.Console.WriteLine(Math.Exp(2));
System.Console.WriteLine(Math.Log(Math.E));
System.Console.WriteLine(Math.Log10(100));

// степени функций
System.Console.WriteLine(Math.Pow(2,3));
System.Console.WriteLine(Math.Sqrt(16));

// вывод констант
System.Console.WriteLine(Math.PI);
System.Console.WriteLine(Math.E);