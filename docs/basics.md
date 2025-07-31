```csharp
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

```