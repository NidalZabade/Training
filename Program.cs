


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


    }


}