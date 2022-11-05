// See https://aka.ms/new-console-template for more information
using Test_Vinay_Simple_Interest;

Console.WriteLine("Hello, World!");

Simple_Interest objSimple = new Simple_Interest();
Console.WriteLine("Enter Principle Amount");
objSimple.PrincipleAmount = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Time");
objSimple.Time = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Rate Of Interest");
objSimple.RateOfInterest = double.Parse(Console.ReadLine());

objSimple.CalculateSimpleInterest();