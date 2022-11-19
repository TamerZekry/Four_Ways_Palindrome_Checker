namespace Palindrome_Words_Checker
{
    public abstract class AbstractPalindrome
    {
        public AbstractPalindrome(string _wordToTest)
        {
            WordToTest = _wordToTest;
        }

        public string WordToTest { get; set; }
        public abstract bool CheckTheWord();
        public void WriteResult()
        {
            Console.Write(" By using ");
            Colored_Console.PrintLine(this.GetType().Name.Substring(15), ConsoleColor.Cyan);
            Console.WriteLine($"The input {WordToTest} {(this.CheckTheWord() ? "is" : "is not")} Palindrome \n");
        }
    }
}
