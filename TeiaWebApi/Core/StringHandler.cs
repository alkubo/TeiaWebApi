namespace TeiaWebApi.Core;


/// <summary>
/// Handles string operations such as checking for palindrome and counting characters.
/// </summary>
public sealed class StringHandler
{
    /// <summary>
    /// Handles the input string by checking if it is a palindrome and counting the characters.
    /// </summary>
    /// <param name="handlerInput">The input containing the text to be handled.</param>
    /// <returns>A <see cref="HandlerResponse"/> object containing the result of the string handling.</returns>
    public HandlerResponse HandleString(HandlerInput handlerInput)
    {
        var isPalindrome = IsPalindrome(handlerInput.Texto);
        var charCount = CountCharacters(handlerInput.Texto);
        return new HandlerResponse(isPalindrome, charCount);
    }

    /// <summary>
    /// Counts the occurrences of each character in the given text.
    /// </summary>
    /// <param name="text">The text to count the characters in.</param>
    /// <returns>A dictionary containing the characters as keys and their counts as values.</returns>
    private Dictionary<char, int> CountCharacters(string text)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in text)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }
        return dict;
    }

    /// <summary>
    /// Checks if the given text is a palindrome.
    /// </summary>
    /// <param name="text">The text to check.</param>
    /// <returns>True if the text is a palindrome, otherwise false.</returns>
    private bool IsPalindrome(string text)
    {
        for (int i = 0, j = text.Length - 1; i < j; i++, j--)
        {
            if (text[i] != text[j])
                return false;
        }
        return true;
    }
}
