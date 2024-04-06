namespace UtilityLibraries;

/// <summary>
/// This class holds extension methods for the string data type
/// </summary> 

public static class StringLibrary
{
     /// <summary>
     /// Detects whether or not the first letter is an uppercase letter.
     /// </summary>
     /// <param name="str">Uses a string type to extend</param>
     /// <returns>True or false meaning the first letter is uppercase or not </returns>
     ///  <example>
     ///  Use this method to detect an upper case letter.
     /// <code>
     /// var x = "Hello".StartsWithUpper();
     /// </code>
     /// </example>


    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}