using System;
using System.Collections.Generic;

class Program
{
    // Question 1: Check if a number is even or odd
    static string IsEvenOrOdd(int num)
    {
        return num % 2 == 0 ? $"The number {num} is even." : $"The number {num} is odd.";
    }

    // Question 2: Find the second smallest number
    static int FindSecondSmallest(int[] nums)
    {
        Array.Sort(nums);
        return nums[1];
    }

    // Question 3: Calculate factorial of a number
    static int CalculateFactorial(int num)
    {
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    // Question 4: Find prime numbers in a range
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static int[] GetPrimesInRange(int start, int end)
    {
        List<int> primes = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i)) primes.Add(i);
        }
        return primes.ToArray();
    }

    // Question 5: Find the largest number in an array using foreach
    static int FindLargest(int[] nums)
    {
        int largest = int.MinValue;
        foreach (int num in nums)
        {
            if (num > largest) largest = num;
        }
        return largest;
    }

    // Question 6: Print number pattern
    static void PrintNumberPattern(int n)
    {
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num++ + " ");
            }
            Console.WriteLine();
        }
    }

    // Question 7: Print pyramid pattern using stars
    static void PrintPyramid(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }

    // Question 8: Sum of even and odd numbers in an array
    static (int evenSum, int oddSum) CalculateSums(int[] nums)
    {
        int evenSum = 0, oddSum = 0;
        foreach (int num in nums)
        {
            if (num % 2 == 0) evenSum += num;
            else oddSum += num;
        }
        return (evenSum, oddSum);
    }

    // Question 9: Find common elements in two arrays
    static int[] FindCommonElements(int[] array1, int[] array2)
    {
        List<int> common = new List<int>();
        foreach (int num1 in array1)
        {
            foreach (int num2 in array2)
            {
                if (num1 == num2 && !common.Contains(num1))
                {
                    common.Add(num1);
                }
            }
        }
        return common.ToArray();
    }

    // Class and Object: Hotel Reservation System
    class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsBooked { get; set; }
        public const string HotelName = "Grand Stay Hotel";

        public void DisplayRoomInfo()
        {
            Console.WriteLine($"Room Number: {RoomNumber}, Room Type: {RoomType}, Price: {PricePerNight:C}, Is Booked: {IsBooked}, Hotel: {HotelName}");
        }
    }

    static void Main(string[] args)
    {
        // Question 1
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(IsEvenOrOdd(number));

        // Question 2
        Console.WriteLine("Enter five numbers:");
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"The 2nd smallest number is: {FindSecondSmallest(numbers)}");

        // Question 3
        Console.Write("Enter a number to calculate its factorial: ");
        int factorialInput = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial of {factorialInput} is: {CalculateFactorial(factorialInput)}");

        // Question 4
        Console.Write("Enter the start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end number: ");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prime numbers between {start} and {end}: {string.Join(", ", GetPrimesInRange(start, end))}");

        // Question 5
        Console.WriteLine("Enter numbers (enter -1 to stop):");
        List<int> numList = new List<int>();
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == -1) break;
            numList.Add(input);
        }
        Console.WriteLine($"The largest number is: {FindLargest(numList.ToArray())}");

        // Question 6
        Console.Write("Enter the number of rows for the number pattern: ");
        int n = int.Parse(Console.ReadLine());
        PrintNumberPattern(n);

        // Question 7
        Console.Write("Enter the height of the pyramid: ");
        int height = int.Parse(Console.ReadLine());
        PrintPyramid(height);

        // Question 8
        Console.WriteLine("Enter numbers (enter -1 to stop):");
        List<int> nums = new List<int>();
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == -1) break;
            nums.Add(input);
        }
        var (evenSum, oddSum) = CalculateSums(nums.ToArray());
        Console.WriteLine($"Sum of Even Numbers: {evenSum}, Sum of Odd Numbers: {oddSum}");

        // Question 9
        Console.WriteLine("Enter the first array (enter -1 to stop):");
        List<int> array1 = new List<int>();
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == -1) break;
            array1.Add(input);
        }
        Console.WriteLine("Enter the second array (enter -1 to stop):");
        List<int> array2 = new List<int>();
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == -1) break;
            array2.Add(input);
        }
        Console.WriteLine($"Common elements: {string.Join(", ", FindCommonElements(array1.ToArray(), array2.ToArray()))}");

        // Class and Object
        Room room1 = new Room
        {
            RoomNumber = 101,
            RoomType = "Single",
            PricePerNight = 50.0m,
            IsBooked = false
        };

        Room room2 = new Room
        {
            RoomNumber = 102,
            RoomType = "Double",
            PricePerNight = 75.0m,
            IsBooked = true
        };

        room1.DisplayRoomInfo();
        room2.DisplayRoomInfo();
    }
}
