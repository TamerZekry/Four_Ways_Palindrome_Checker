namespace Palindrome_Words_Checker
{
    public class PalindromeUsingLinq : AbstractPalindrome
    {
        public PalindromeUsingLinq(string _wordToTest) : base(_wordToTest)
        {
        }

        public override bool CheckTheWord()
        {
            return string.Join("", WordToTest.ToLower().Reverse().ToArray()) == WordToTest.ToLower();
        }

    }
}
