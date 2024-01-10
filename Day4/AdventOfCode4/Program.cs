// See https://aka.ms/new-console-template for more information

using AdventOfCode4.Services;

Console.WriteLine("Hello, World!");

var processing = new Processing();
var result = processing.ProcessCards();
Console.WriteLine($"Done! {result}");