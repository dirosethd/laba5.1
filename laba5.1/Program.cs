char[] text = "This is a sample text with some words beginning with B".ToCharArray();

int count = CountWordsStartingWith(text, 'b');

        Console.WriteLine("Количество слов, начинающихся с буквы 'b': " + count);
    static int CountWordsStartingWith(char[] text, char letter)
    {
        bool inWord = false;
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (!inWord && IsLetter(text[i]) && ToLower(text[i]) == letter)
            {
                if ((i == 0 || !IsLetter(text[i - 1])))
                {
                    count++;
                    inWord = true;
                }
            }
            else if (IsLetter(text[i]))
            {
                inWord = true;
            }
            else
            {
                inWord = false;
            }
        }

        return count;
    }

    static bool IsLetter(char c)
    {
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
    }

    static char ToLower(char c)
{
    if (c >= 'A' && c <= 'Z')
    {
        return (char)(c + ('a' - 'A'));
    }
    return c;
}