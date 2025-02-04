
int SkipLeadingSpaces(string str, int startIdx)
{
    for (int i = startIdx; i < str.Length; i++)
    {
        if (!char.IsWhiteSpace(str[i]))
        {
            return i;
        }
    }
    return str.Length;
}