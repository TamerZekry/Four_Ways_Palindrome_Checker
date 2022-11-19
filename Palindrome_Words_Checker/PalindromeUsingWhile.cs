namespace Palindrome_Words_Checker
{
    public class PalindromeUsingWhile : AbstractPalindrome
    {
        public PalindromeUsingWhile(string _wordToTest) : base(_wordToTest)
        {
        }

        public override bool CheckTheWord()
        {
            string LowerCaseWord = WordToTest.ToLower();
            int reverseCounter = WordToTest.Length - 1;
            int forwardCounter = 0;
            bool result = true;

            while (reverseCounter - forwardCounter >= 0)
            {
                if (LowerCaseWord[forwardCounter] != LowerCaseWord[reverseCounter])
                {
                    result = false;
                }
                reverseCounter--;
                forwardCounter++;
            };
            return result; ;
        }
    }
}
