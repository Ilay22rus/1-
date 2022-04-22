// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 2;
int b = 3;
int c = 7;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);