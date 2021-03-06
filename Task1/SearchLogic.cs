﻿using System;

namespace Task1
{
    public static class SearchLogic
    {
        public static int[] CreateArray(int lenth)
        {
            Random rdm = new Random();

            int[] mass = new int[lenth];

            for (var i = 0; i < lenth; i++)
            {
                mass[i] = rdm.Next(int.MinValue, int.MaxValue);
            }

            Array.Sort(mass);

            return mass;
        }

        public static int? BinarySearch(int[] array, int number)
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

            int low = 0;
            int high = array.Length;
            int mid = (low + high) / 2;

            watch.Start();
            while (low < high)
            {
                mid = (low + high) / 2;
                if (number == array[mid])
                    return mid;
                if (number > array[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            watch.Stop();

            return null;
        }
    }
}
