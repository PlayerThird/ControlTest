// See https://aka.ms/new-console-template for more information
using ControlTest;

Console.WriteLine("Hello, World!2.0");
Console.WriteLine("");
string[] originalArray = {"324234", "23", "Pri","gb35","ve","f3j5h","t", ".","wgty4"
,"fjh4h","Wor","gvh3j","ldr","+_((^","^_^"};
string[] doubleArray = ArrayWork.Filter(originalArray);
ArrayWork.PrintMass("1й массив", originalArray);
ArrayWork.PrintMass("2й массив", doubleArray);
Console.ReadLine();
