using System;

class Program
{
    static void Main()
    {
        int x = 10;
        int y = 5;

        Console.Clear(); // Очищаем один раз в самом начале
        Console.CursorVisible = false; // Чтобы курсор не мигал рядом с @

        while (true)
        {
            // 1. Рисуем игрока в текущей позиции
            Console.SetCursorPosition(x, y);
            Console.Write("@");

            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape) break;

            // 2. СТИРАЕМ игрока в СТАРОЙ позиции прежде чем изменить координаты
            // Просто рисуем пробел там, где мы сейчас стоим
            Console.SetCursorPosition(x, y);
            Console.Write(" "); 

            // 3. Изменяем координаты
            if (key.Key == ConsoleKey.W) y--;
            else if (key.Key == ConsoleKey.S) y++;
            else if (key.Key == ConsoleKey.A) x--;
            else if (key.Key == ConsoleKey.D) x++;

            // 4. Ограничиваем координаты (чтобы не вылететь за края реального окна)
            x = Math.Clamp(x, 0, Console.WindowWidth - 1);
            y = Math.Clamp(y, 0, Console.WindowHeight - 1);
        }
    }
}