using System;

class Program
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
        Array.Sort(numbers); // Ensure the array is sorted for binary search

        Console.Write("Enter a number to search for: ");
        int target = int.Parse(Console.ReadLine());

        int result = BinarySearch(numbers, target);

        if (result != -1)
        {
            Console.WriteLine($"Number {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Number {target} not found in the array");
        }
    }
}