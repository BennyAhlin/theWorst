// See https://aka.ms/new-console-template for more information

using theWorst;

using System.Collections.Concurrent;


Console.WriteLine("Hello, World!");



Intro intro = new Intro();
intro.GameIntro();

var x = 10;
while (x != 0)
{
    Console.WriteLine("arvid är en snäll pöjk");
    x--;
}


Console.WriteLine("va heder du");
string name = Console.ReadLine();
Console.WriteLine("hej " + name);



Console.WriteLine("Line 10 starts here!");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Count: " + i);
}


string input = Console.ReadLine();
Console.Clear();
Console.WriteLine(input);


//string temp = string.Empty;
foreach (var item in input)
{
    Console.WriteLine(input);
}