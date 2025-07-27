
namespace numbersProblems
{
    class numbersProblems
    {


        public static int FindSecondLargest(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return -1;

            int largest = -999999999;
            int secondLargest = -999999999;

            foreach (int number in arr)
            {
                if (number > largest)
                {
                    secondLargest = largest;
                    largest = number;
                }
                else if (number > secondLargest && number < largest)
                {
                    secondLargest = number;
                }
            }

            if (secondLargest == -99999999)
                return -1;

            return secondLargest;
        }

        public static int FindMissingNumber(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Input array cannot be null or empty.");

            int n = arr.Length + 1;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int number in arr)
            {
                actualSum += number;
            }

            return expectedSum - actualSum;
        }

        public static int[] SortArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public static int FindLargest(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Input array cannot be null or empty.");

            int largest = arr[0];

            foreach (int number in arr)
            {
                if (number > largest)
                    largest = number;
            }

            return largest;
        }

        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentException("Input arrays cannot be null.");

            int[] mergedArray = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }

            while (i < arr1.Length)
            {
                mergedArray[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                mergedArray[k++] = arr2[j++];
            }

            return mergedArray;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

    }
}