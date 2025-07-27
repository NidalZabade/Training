

namespace stringProblems
{

    class stringProblems
    {
        public static char FirstNonRepeatedChar(string str)
        {
            if (str == null || str.Length == 0)
                return '\0';
            str = str.ToLower();
            int[] charCount = new int[26];

            for (int i = 0; i < str.Length; i++)
            {
                charCount[(int)(str[i] - 'a')]++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[(int)(str[i] - 'a')] == 1)
                    return str[i];
            }

            return '\0';
        }

        public static int CountVowels(string str)
        {
            if (str.Length == 0)
                throw new ArgumentException("Input string cannot be empty.");

            int count = 0;
            foreach (char c in str)
            {
                char lower = char.ToLower(c);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    count++;
            }

            return count;
        }


    }
}