﻿
Console.Write("Reqem:");
int point = Convert.ToInt32(Console.ReadLine());

Console.Write("Neticeniz:");
if (point < 0 && point > 100)
{
    Console.WriteLine("Duzgun reqem daxil et");

}
else if (point >= 91 && point <= 100)
{
    Console.WriteLine("A");
}
else if
    (point >= 81 && point <= 90)
{
    Console.WriteLine("B");
}
else if (point >= 71 && point <= 80)
{
    Console.WriteLine("C");
}
else if (point >= 61 && point <= 70)
{
    Console.WriteLine("D");
}
else if (point >= 51 && point <= 60)
{
    Console.WriteLine("E");
}
else
{
    Console.WriteLine("Kesildiz");
}