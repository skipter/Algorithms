namespace IsPalindrome
{
    using System;
    public class IsPalindrone
    {
        public static void Main()
        {

        }
        // Palindrome method
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)             //Can use char.ToLower(a) != char.ToLower(b) , will check faster, If you dont need to look for Upper chars.
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
