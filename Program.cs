using DelegatesDemo.Delegates;
using DelegatesDemo.Interfaces;

IFunctionDelegate<string, string> reverseStringDelegate = new FunctionDelegate<string, string>(ReverseString);
string reversedName = reverseStringDelegate.Execute("Developer");
Console.WriteLine("Reversed Name: " + reversedName);

// Using Action delegate
IActionDelegate<string> printMessageDelegate = new ActionDelegate<string>(PrintMessage);
printMessageDelegate.Execute("Hello, Developer!");

Console.ReadLine();

string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

void PrintMessage(string message)
{
    Console.WriteLine("Message: " + message);
}
