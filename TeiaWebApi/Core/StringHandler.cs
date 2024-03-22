namespace TeiaWebApi.Core;


/// <summary>
/// Provides methods for handling strings.
/// </summary>
public static class StringHandler
{
    /// <summary>
    /// Handles the given string by counting characters, clearing the text, and checking if it is a palindrome.
    /// </summary>
    /// <param name="text">The input string to handle.</param>
    /// <returns>A <see cref="HandlerResponse"/> object containing the result of handling the string.</returns>
    public static HandlerResponse HandleString(string text)
    {
        var charCount = CountCharacters(text);

        if (TryClearText(text, out string clearText))
        {
            var isPalindrome = IsPalindrome(clearText);

            return new HandlerResponse(isPalindrome, charCount);
        }
        return new HandlerResponse(false, charCount);
    }

    /// <summary>
    /// Tries to clear the given text by removing non-letter characters and converting it to lowercase.
    /// </summary>
    /// <param name="text">The input text to clear.</param>
    /// <param name="clearText">The cleared text.</param>
    /// <returns><c>true</c> if the text was successfully cleared; otherwise, <c>false</c>.</returns>
    private static bool TryClearText(string? text, out string clearText)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            clearText = string.Empty;
            return false;
        }

        clearText = new string(text.Where(char.IsLetter).ToArray()).ToLower();
        return string.IsNullOrWhiteSpace(clearText) is false;
    }

    /// <summary>
    /// Counts the occurrences of each character in the given text.
    /// </summary>
    /// <param name="text">The input text to count characters.</param>
    /// <returns>A dictionary containing the characters as keys and their counts as values.</returns>
    private static Dictionary<char, int> CountCharacters(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return new Dictionary<char, int>();

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
    /// <param name="text">The input text to check.</param>
    /// <returns><c>true</c> if the text is a palindrome; otherwise, <c>false</c>.</returns>
    private static bool IsPalindrome(string text)
    {
        int i = 0;
        int j = text.Length - 1;

        while (i < j)
        {
            if (text[i] != text[j])
                return false;

            i++;
            j--;
        }

        return true;
    }
}
