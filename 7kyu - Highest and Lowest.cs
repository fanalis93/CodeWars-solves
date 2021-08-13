using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var numList = numbers.Split(' ').Select(Int32.Parse).ToArray();

    return $"{numList.Max()} {numList.Min()}";
  }
}
