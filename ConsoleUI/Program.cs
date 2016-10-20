using System;
using task = Task1.SearchLogic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();

            int[] array = task.CreateArray(100);

            int? index = task.BinarySearch(array, rdm.Next(array[0], array[array.Length - 1]));

        }
    }
}
