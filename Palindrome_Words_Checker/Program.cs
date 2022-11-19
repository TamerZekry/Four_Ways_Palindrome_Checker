using Palindrome_Words_Checker;
var IsValidInput = false;
AbstractPalindrome Palindrome;
string input;


Colored_Console.PrintLine("Welcome To", ConsoleColor.Green, 5, (Console.WindowWidth / 2) - 10);
Colored_Console.PrintLine("Palindrome Checker  \n", ConsoleColor.Green, 6, (Console.WindowWidth / 2) - 14);
do
{
    Colored_Console.Print("Please enter a word to check: ", ConsoleColor.Yellow);
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input) || input.Length < 2)
    {
        IsValidInput = false;
        Colored_Console.PrintLine("Invalid input \n", ConsoleColor.Red);
    }
    else
    {
        IsValidInput = true;
    }


} while (!IsValidInput);
Palindrome = new PalindromeUsingLinq(input);
Palindrome.WriteResult();
Palindrome = null;

Palindrome = new PalindromeUsingFor(input);
Palindrome.WriteResult();
Palindrome = null;

Palindrome = new PalindromeUsingDo(input);
Palindrome.WriteResult();
Palindrome = null;


Palindrome = new PalindromeUsingWhile(input);
Palindrome.WriteResult();
Palindrome = null;






