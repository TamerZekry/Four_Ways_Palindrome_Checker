namespace Palindrome_Words_Checker
{
    internal class PalindromeUsingDo : AbstractPalindrome
    {
        public PalindromeUsingDo(string _wordToTest) : base(_wordToTest) { }

        public override bool CheckTheWord()
        {
            string LowerCaseWord = WordToTest.ToLower();
            int reverseCounter = WordToTest.Length - 1;
            int forwardCounter = 0;
            bool result = true;

            do
            {
                if (LowerCaseWord[forwardCounter] != LowerCaseWord[reverseCounter])
                {
                    result = false;
                }

                reverseCounter--;
                forwardCounter++;
            } while (reverseCounter - forwardCounter >= 1);
            return result; ;
        }
    }
}
