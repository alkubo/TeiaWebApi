using System.Text.Json.Serialization;

namespace TeiaWebApi.Core;


/// <summary>
/// Represents the response from a handler.
/// </summary>
public readonly struct HandlerResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HandlerResponse"/> struct.
    /// </summary>
    /// <param name="palindromo">Indicates whether the response is a palindrome.</param>
    /// <param name="ocorrencias_caracteres">The dictionary containing the occurrences of characters.</param>
    public HandlerResponse(bool palindromo, IReadOnlyDictionary<char, int> ocorrencias_caracteres)
    {
        IsPalindrome = palindromo;
        CharacterCount = ocorrencias_caracteres;
    }

    /// <summary>
    /// Gets a value indicating whether the response is a palindrome.
    /// </summary>
    [JsonPropertyName("palindromo")]
    public bool IsPalindrome { get; }

    /// <summary>
    /// Gets the dictionary containing the occurrences of characters.
    /// </summary>
    [JsonPropertyName("ocorrencias_caracteres")]
    public IReadOnlyDictionary<char, int> CharacterCount { get; }
}
