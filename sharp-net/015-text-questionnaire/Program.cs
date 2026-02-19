string greeting = "Приветствую на викторине.";
string q1 = "Что означает car. [mashina, vorona]";
string q2 = "Почему программа не воспринимает кириллицу. [neznau, potom sdelau]";
string nope = "Не верно...";

int score = 0;

Console.WriteLine($"{greeting}\n{q1}");
if (Console.ReadLine().ToLower().Trim() != "mashina")
{
    Console.WriteLine($"{nope}");
}
else
{
    score += 10;
    Console.WriteLine($"Верно! +10 баллов. У вас {score} баллов!");
}

Console.WriteLine($"{q2}");
if (Console.ReadLine().ToLower().Trim() == "potom sdelau")
{
    score += 10;
    Console.WriteLine($"Верно! +10 баллов. У вас {score} баллов!");
}
else
{
    Console.WriteLine($"{nope}");
}

Console.WriteLine($"Викторина завершена, у вас {score} баллов.");