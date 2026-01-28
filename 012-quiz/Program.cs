Console.WriteLine($"Приветствую на нашей СУПЕР ВИКТОРИНЕ!");
Console.WriteLine($"============================================================");
Console.WriteLine($"ДЛЯ КОРРЕКТНОГО ВВОДА ИСПОЛЬЗУЕТСЯ ТОЛЬКО ЛАТИНИЦА!");
Console.WriteLine($"Испытайте себя в самом интелектуальном шоу на планете!");
Console.WriteLine($"============================================================");
Console.Write($"Для начала - РЕГИСТРАЦИЯ! Введите имя участника: ");
string nickname = Console.ReadLine();
int score = 10;
Console.WriteLine($"ОТЛИЧНО! + 10 БАЛЛОВ! ТАК ДЕРЖАТЬ {nickname.ToUpper()}! " +
"Если так пойдет и дальше, то у нас закончатся баллы!");
Console.WriteLine($"============================================================");
Console.WriteLine($"И МЫ НАЧИНАЕМ!");
Console.Write($"Как будете готовы, нажмите любую клавишу что бы продолжить...");
Console.ReadLine();
Console.WriteLine($"============================================================");

Console.WriteLine($"Первый вопрос:");
Console.WriteLine($"Зачем программисту резиновая уточка на столе?");
Console.WriteLine($"A) Для красоты и уюта");
Console.WriteLine($"B) Она нажимает на клавиши, пока он спит");
Console.WriteLine($"C) Чтобы объяснять ей свой код и находить ошибки (Метод утёнка)");
Console.WriteLine($"D) Чтобы пугать менеджеров");
char answer = char.Parse(Console.ReadLine().ToLower());
if (answer == 'c')
{
    score += 10;
    Console.WriteLine($"ОТЛИЧНО! У ТЕБЯ УЖЕ {score} БАЛЛОВ!");
}
else
{
    Console.WriteLine($"Не в этот раз 🤭");
}

Console.Write($"Как будете готовы, нажмите любую клавишу что бы продолжить...");
Console.ReadLine();
Console.WriteLine($"============================================================");
Console.WriteLine($"Следующий вопрос:");
Console.WriteLine($"Какой «вид спорта» больше всего популярен среди разработчиков перед дедлайном?");
Console.WriteLine($"A) Прыжки через баги");
Console.WriteLine($"B) Скоростное гугление на Stack Overflow");
Console.WriteLine($"C) Метание клавиатуры в стену");
Console.WriteLine($"D) Синхронное удаление комментариев");
ConsoleKeyInfo keyInfo = Console.ReadKey(true);
if (char.ToLower(keyInfo.KeyChar) == 'b')
{
    score += 10;
    Console.WriteLine($"ОТЛИЧНО! У ТЕБЯ УЖЕ {score} БАЛЛОВ!");
}
else
{
 Console.WriteLine($"В следующий раз угадаешь 🤭");   
}

Console.Write($"Готовы узнать результат? ТОГДА нажмите любую клавишу что бы продолжить...");
Console.ReadLine();
Console.WriteLine($"============================================================");
Console.WriteLine($"ПОДВЕДЕМ НАШИ ИТОГИ!!");

string result = score switch
{
    0 => "ЭТО КАК МОЖНО БЫЛО УМУДРИТЬСЯ?",
    10 => "ОТЛИЧНЫЙ РЕЗУЛЬТАТ! ВЫ СПОСОБНЕЕ 70% ИГРОКОВ",
    20 => "ВАУ!!! Я ПОД БОЛЬШИМ ВПЕЧАТЛЕНИЕМ!",
    30 => "Поздравляю. К сожалению нам придется подать на банкротство из за ВАШЕЙ БЕЗУСЛОВНОЙ ПОБЕДЫ!!!"
};
Console.WriteLine($"============================================================");
Console.WriteLine($"{nickname} - {result} Ваше колличество баллов: {score} из 30 возможных!");