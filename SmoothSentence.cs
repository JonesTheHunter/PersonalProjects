// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class SmoothSentence
{
    /*Carlos is a huge fan of something he calls smooth sentences.
      A smooth sentence is one where the last letter of each word is identical to the first letter the following word (and not case sensitive, so "A" would be the same as "a").
      The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
      Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.
      IsSmooth("Marta appreciated deep perpendicular right trapezoids") ➞ true
      IsSmooth("Someone is outside the doorway") ➞ false
      IsSmooth("She eats super righteously") ➞ true
      The last and first letters are case insensitive.
      There will be no punctuation in each sentence.*/

      public static void IsSmooth(string userInput)
    {
        
        char[] messageToArray = userInput.Trim().ToCharArray();
        bool isSmooth = false;
        for(int mesChar = 0; mesChar < messageToArray.Length; mesChar++)
        {
            if (Char.IsWhiteSpace(messageToArray[mesChar]))
            {
                if(messageToArray[mesChar + 1] == messageToArray[mesChar - 1])
                {
                    isSmooth = true;
                }
                else
                {
                    isSmooth = false;
                }
                
            }
        }

        Console.WriteLine("\'{0}\' is classified as {1}.\n", userInput, isSmooth);

    }

    public static void Main(string[] arg)
    {

        Console.WriteLine("Enter Smooth sentence. If correct, will return true. If wrong, will return false. \nDont use punctuation \nLetters are case sensitive.\nOne sentence per input.\n\n\n");
        string message = Console.ReadLine();
        IsSmooth(message);

        IsSmooth("Marta appreciated deep perpendicular right trapezoids");    //Outputs: True
        IsSmooth("Someone is outside the doorway");                           //Outputs: False
        IsSmooth("She eats super righteously");                               //Outputs: True
    }
}
