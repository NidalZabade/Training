
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { -5, -3, -8, -9, -2, -8, -1, -7, 0 };
        int secondLargest = numbersProblems.numbersProblems.FindSecondLargest(numbers);
        Console.WriteLine("The second largest number is: " + secondLargest);

        string input = "swiss";
        char firstNonRepeated = stringProblems.stringProblems.FirstNonRepeatedChar(input);
        if (firstNonRepeated != '\0')
        {
            Console.WriteLine("The first non-repeated character is: " + firstNonRepeated);
        }
        else
        {
            Console.WriteLine("No non-repeated character found.");
        }

        int[] missingNumbers = { 1, 2, 4, 6, 3, 7, 8 };
        try
        {
            int missingNumber = numbersProblems.numbersProblems.FindMissingNumber(missingNumbers);
            Console.WriteLine("The missing number is: " + missingNumber);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        int[] arrayToSort = { 5, 3, 8, 6, 2 };
        int[] sortedArray = numbersProblems.numbersProblems.SortArray(arrayToSort);
        Console.WriteLine("Sorted array: " + string.Join(", ", sortedArray));

        int[] arrayToFindLargest = { 5, 3, 8, 6, 2 };
        try
        {
            int largestNumber = numbersProblems.numbersProblems.FindLargest(arrayToFindLargest);
            Console.WriteLine("The largest number is: " + largestNumber);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        string vowelString = "Hello World";
        try
        {
            int vowelCount = stringProblems.stringProblems.CountVowels(vowelString);
            Console.WriteLine("Number of vowels in the string: " + vowelCount);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        string reverseString = "Hello World";
        string? reversed = stringProblems.stringProblems.ReverseString(reverseString);
        Console.WriteLine("Reversed string: " + reversed);

        int[] firstArray = { 1, 2, 3, 6, 8 };
        int[] secondArray = { 4, 5, 6 };
        int[] mergedArray = numbersProblems.numbersProblems.MergeSortedArrays(firstArray, secondArray);
        Console.WriteLine("Merged array: " + string.Join(", ", mergedArray));

        string str = "125893";
        bool containsOnlyDigits = stringProblems.stringProblems.ContainsOnlyDigits(str);
        Console.WriteLine("Contains only digits: " + containsOnlyDigits);

        MainAsync().Wait();

        int[] set = { 1, 2, 3 };
        List<int[]> subsets = numbersProblems.numbersProblems.FindAllSubsets(set);
        Console.WriteLine("All subsets:");
        Console.WriteLine("[" + string.Join(", ", subsets.Select(subset => "[" + string.Join(",", subset) + "]")) + "]");

        int[] arr = { 1, 2, 3, 4, 5 };
        int indexIterative = numbersProblems.numbersProblems.BinarySearchIterative(arr, 3);
        if (indexIterative != -1)
        {
            Console.WriteLine("Element found at index: " + indexIterative);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }

        int indexRecursive = numbersProblems.numbersProblems.BinarySearchRecursive(arr, 3, 0, arr.Length - 1);
        if (indexRecursive != -1)
        {
            Console.WriteLine("Element found at index: " + indexRecursive);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
        
    }

    public static async Task MainAsync()
    {
        int start = 1, end = 1000000;
        List<int> primeNumbers = await multithreadingProblems.multithreadingProblems.FindPrimeNumbersAsync(start, end);
        Console.WriteLine("Prime numbers between " + start + " and " + end + ": " + string.Join(", ", primeNumbers));
    }

    


}