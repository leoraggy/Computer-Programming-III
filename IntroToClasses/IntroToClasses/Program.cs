﻿// See https://aka.ms/new-console-template for more information
using IntroToClasses;

Console.WriteLine("Cerating a dog object");
Dog d1 = new("Zhongli", "German Shepherd", "black", 2, 100);
Console.WriteLine(d1.Name);
d1.Name = "Venti";
Console.WriteLine(d1.Name);
Console.WriteLine("\n\npress <return> to exit program");
Console.ReadLine();