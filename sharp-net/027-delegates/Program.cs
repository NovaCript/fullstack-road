// signature IsEven - int bool

bool IsEven(int x)
{
    return x % 2 == 0;
}

// int x = 2;
// double y = 1.2;

MyMethodDelegate method = IsEven;
var x = method(2);
var y = method(1);
System.Console.WriteLine(x);
System.Console.WriteLine(y);

delegate bool MyMethodDelegate(int vlaue);
