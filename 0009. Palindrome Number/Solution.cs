namespace Test._0009._Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            var str = x.ToString();

            return string.Equals(str, string.Join("", str.Reverse()));
        }
    }
}
