using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}

		public bool IsAPalindrome(string word)
		{
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                    return false;
            }
            return true;

        }
    }
}

