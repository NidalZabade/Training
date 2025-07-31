
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

        public static List<int[]> FindAllSubsets(int[] set)
        {
            List<int[]> subsets = new List<int[]>();
            FindAllSubsetsRecursive(set, 0, new List<int>(), subsets);
            return subsets;
        }

        private static void FindAllSubsetsRecursive(int[] set, int index, List<int> current, List<int[]> subsets)
        {
            if (index == set.Length)
            {
                subsets.Add(current.ToArray());
                return;
            }

            // Exclude current element
            FindAllSubsetsRecursive(set, index + 1, current, subsets);

            // Include current element
            current.Add(set[index]);
            FindAllSubsetsRecursive(set, index + 1, current, subsets);
            current.RemoveAt(current.Count - 1);
        }

        //binary search iterative
        public static int BinarySearchIterative(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Input array cannot be null or empty.");

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        //binary search recursive
        public static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Input array cannot be null or empty.");

            if (left > right)
                return -1;

            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                return BinarySearchRecursive(arr, target, mid + 1, right);
            else
                return BinarySearchRecursive(arr, target, left, mid - 1);
        }


        public static Dictionary<(int, int), int> CompressSparseMatrix(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentException("Input matrix cannot be null.");

            var compressed = new Dictionary<(int, int), int>();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        compressed[(i, j)] = matrix[i, j];
                    }
                }
            }
            return compressed;
        }

        public static int[,] DecompressSparseMatrix(Dictionary<(int, int), int> compressed, int rows, int cols)
        {
            if (compressed == null)
                throw new ArgumentException("Compressed dictionary cannot be null.");
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Matrix dimensions must be positive.");

            int[,] matrix = new int[rows, cols];

            foreach (var kvp in compressed)
            {
                var (i, j) = kvp.Key;
                if (i < 0 || i >= rows || j < 0 || j >= cols)
                    throw new ArgumentException("Invalid coordinate in compressed dictionary.");
                matrix[i, j] = kvp.Value;
            }

            return matrix;
        }

    }
}