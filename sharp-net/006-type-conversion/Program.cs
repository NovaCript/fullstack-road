// неявное преобразование
int myInt = 123; // 4 byte
double myDouble = myInt; // 8 byte
Console.WriteLine(myDouble);

// явное преобразование
double anotherDouble = 123.456;
int anotherInt = (int)anotherDouble;
Console.WriteLine(anotherInt);

// преобразование классом
string intString = "123";
int fromStringToInt = Convert.ToInt32(intString);
Console.WriteLine(fromStringToInt);

// преобразование методом parse
string doubleString = "123.456";
double fromStringToDouble = double.Parse(doubleString);
Console.WriteLine(fromStringToDouble);

// преобразование TryParse
string invalidIntString = "123.456";
int parseResult;
bool isSuccess = int.TryParse(invalidIntString, out parseResult);
System.Console.WriteLine(isSuccess);
System.Console.WriteLine(parseResult);