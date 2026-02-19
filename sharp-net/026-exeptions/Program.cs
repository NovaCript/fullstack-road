int[] array = new int[10];



try
{
    System.Console.WriteLine(array[12]);
}
catch (System.Exception ex)
{
    
    System.Console.WriteLine("Какая то ошибка: " + ex.Message);
}
finally
{
    System.Console.WriteLine("Завершение проверки");
}