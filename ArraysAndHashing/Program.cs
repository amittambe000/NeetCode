// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using ArraysAndHashing;

Console.WriteLine("Arrays and Hashing!");

var duplicate = new Contains_Duplicate().ContainsDuplicate(new int[] {1, 2, 3, 4});
Console.WriteLine(duplicate);
