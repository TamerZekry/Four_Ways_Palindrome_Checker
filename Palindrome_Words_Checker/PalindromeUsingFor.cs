namespace Palindrome_Words_Checker
{
    public class PalindromeUsingFor : AbstractPalindrome
    {
        public PalindromeUsingFor(string _wordToTest) : base(_wordToTest) { }

        public override bool CheckTheWord()
        {
            string LowerCaseWord = WordToTest.ToLower();
            int reversecounter = WordToTest.Length - 1;
            bool result = true;

            for (int i = 0; i < WordToTest.Length; i++)
            {
                if (LowerCaseWord[i] != LowerCaseWord[reversecounter])
                {
                    result = false;
                }
                if (i - reversecounter == 1)
                {
                    break;
                }
                reversecounter--;
            }
            return result; ;
        }
    }
}
