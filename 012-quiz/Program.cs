string line = "============================================================";
string continueLine = "Как будете готовы, нажмите Enter, чтобы продолжить...";

Console.Clear();
Console.WriteLine($"Приветствую на нашей СУПЕР ВИКТОРИНЕ!");
Console.WriteLine($"{line}");
Console.WriteLine($"ДЛЯ КОРРЕКТНОГО ВВОДА ИСПОЛЬЗУЕТСЯ ТОЛЬКО ЛАТИНИЦА!");
Console.WriteLine($"Испытайте себя в самом интеллектуальном шоу на планете!");
Console.WriteLine($"{line}");
Console.Write($"Для начала - РЕГИСТРАЦИЯ! Введите имя участника: ");
string nickname = Console.ReadLine();
while (nickname == "")
{
    Console.WriteLine($"Обязательно введи имя!");
    nickname = Console.ReadLine();
}
int score = 10;
Console.WriteLine($"ОТЛИЧНО! + 10 БАЛЛОВ! ТАК ДЕРЖАТЬ {nickname.ToUpper()}! " +
"Если так пойдет и дальше, то у нас закончатся баллы!");
Console.WriteLine($"{line}");
Console.WriteLine($"И МЫ НАЧИНАЕМ!");
Console.Write(continueLine);
Console.ReadLine();
Console.WriteLine($"{line}");

Console.WriteLine($"Первый вопрос:");
Console.WriteLine($"Зачем программисту резиновая уточка на столе?");
Console.WriteLine($"A) Для красоты и уюта");
Console.WriteLine($"B) Она нажимает на клавиши, пока он спит");
Console.WriteLine($"C) Чтобы объяснять ей свой код и находить ошибки (Метод утёнка)");
Console.WriteLine($"D) Чтобы пугать менеджеров");
ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine($"");
if (char.ToLower(keyInfo.KeyChar) == 'c')
{
    score += 10;
    Console.WriteLine($"ОТЛИЧНО! У ТЕБЯ УЖЕ {score} БАЛЛОВ!");
}
else
{
    Console.WriteLine($"Не в этот раз 🤭");
}

Console.Write(continueLine);
Console.ReadLine();
Console.WriteLine($"{line}");
Console.WriteLine($"Следующий вопрос:");
Console.WriteLine($"Какой «вид спорта» больше всего популярен среди разработчиков перед дедлайном?");
Console.WriteLine($"A) Прыжки через баги");
Console.WriteLine($"B) Скоростное гугление на Stack Overflow");
Console.WriteLine($"C) Метание клавиатуры в стену");
Console.WriteLine($"D) Синхронное удаление комментариев");
keyInfo = Console.ReadKey();
Console.WriteLine($"");
if (char.ToLower(keyInfo.KeyChar) == 'b')
{
    score += 10;
    Console.WriteLine($"ОТЛИЧНО! У ТЕБЯ УЖЕ {score} БАЛЛОВ!");
}
else
{
 Console.WriteLine($"В следующий раз угадаешь 🤭");   
}

Console.Write($"Готовы узнать результат? ТОГДА нажмите Enter, чтобы продолжить...");
Console.ReadLine();
Console.WriteLine($"{line}");
Console.WriteLine($"ПОДВЕДЕМ НАШИ ИТОГИ!!");

string result = score switch
{
    0 => "ЭТО КАК МОЖНО БЫЛО УМУДРИТЬСЯ?",
    10 => "ОТЛИЧНЫЙ РЕЗУЛЬТАТ! ВЫ СПОСОБНЕЕ 70% ИГРОКОВ",
    20 => "ВАУ!!! Я ПОД БОЛЬШИМ ВПЕЧАТЛЕНИЕМ!",
    30 => "Поздравляю. К сожалению, нам придется подать на банкротство из-за ВАШЕЙ БЕЗУСЛОВНОЙ ПОБЕДЫ!!!"
};
Console.WriteLine($"{line}");
Console.WriteLine($"{nickname} - {result} Ваше количество баллов: {score} из 30 возможных!");