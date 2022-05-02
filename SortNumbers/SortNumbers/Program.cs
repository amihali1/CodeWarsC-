// See https://aka.ms/new-console-template for more information
using SortNumbers;

Console.WriteLine("Hello, World!");


var unsortedNums = new int[] { 1, 3, 2, 4, 6, 5 };

var kata = new Kata();
Console.Write("Sorting: ");
Array.ForEach(unsortedNums, Console.Write);
Console.WriteLine();
var sortedNums = Kata.SortNumbers(unsortedNums);
Console.WriteLine("Sorted: ");
Array.ForEach(sortedNums, Console.Write);
Console.WriteLine();

