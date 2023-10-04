// See https://aka.ms/new-console-template for more information

using theWorst;

using System.Collections.Concurrent;


Console.WriteLine("Hello, World!");



Intro intro = new Intro();
intro.GameIntro();




Console.WriteLine("Line 10 starts here!");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Count: " + i);
}


string input = Console.ReadLine();
Console.Clear();
Console.WriteLine(input);

