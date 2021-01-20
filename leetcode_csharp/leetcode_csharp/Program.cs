using System;

namespace leetcode_csharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            char x = ThreeightnineFindTheDifference.FindTheDifference("aba", "abba");
            char y = ThreeightnineFindTheDifference.FindTheDifference("abcd", "abcde");
            char z = ThreeightnineFindTheDifference.FindTheDifference("", "y");
            char w = ThreeightnineFindTheDifference.FindTheDifference("a", "a");
            char q = ThreeightnineFindTheDifference.FindTheDifference("ae", "aea");
            Console.WriteLine($"{x}  {y}   {z}   {w}    {q}");
        }
        
    }
}