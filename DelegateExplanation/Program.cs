

// See https://aka.ms/new-console-template for more information
using DelegateExplanation;

Console.WriteLine("Hello, World!");
MyClass obj =  new MyClass();
obj.LongRunning(Callback);

static void Callback(int i)
{
    Console.WriteLine(i);
}

