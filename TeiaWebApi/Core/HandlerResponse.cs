namespace TeiaWebApi.Core;

/// <summary>
/// Represents the response from a handler.
/// </summary>
public readonly struct HandlerResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HandlerResponse"/> struct.
    /// </summary>
    /// <param name="palindromo">Indicates whether the input is a palindrome.</param>
    /// <param name="ocorrencias_caracteres">The occurrences of each character in the input.</param>
    public HandlerResponse(bool palindromo, Dictionary<char, int> ocorrencias_caracteres) : this()
    {
        Palindromo = palindromo;
        Ocorrencias_Caracteres = ocorrencias_caracteres;
    }

    /// <summary>
    /// Gets a value indicating whether the input is a palindrome.
    /// </summary>
    public bool Palindromo { get; }

    /// <summary>
    /// Gets the occurrences of each character in the input.
    /// </summary>
    public Dictionary<char, int> Ocorrencias_Caracteres { get; }
}
