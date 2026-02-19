/*
for (int i = 0; i < length; i++)
{
    //body
}

do
{
    //body
} while (false);

while (false)
{
    //body
}


foreach (var item in collection)
{
    //body
}
*/


for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine($"[{i}]");
}

Console.WriteLine($"---------------------");

for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine($"[{i}]");
}