
namespace multithreadingProblems
{
    class multithreadingProblems
    {
        public static async Task<List<int>> FindPrimeNumbersAsync(int start, int end)
        {
            return await Task.Run(() =>
            {
                List<int> primes = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    if (numbersProblems.numbersProblems.IsPrime(i))
                    {
                        primes.Add(i);
                    }
                }
                return primes;
            });
        }
    }
}