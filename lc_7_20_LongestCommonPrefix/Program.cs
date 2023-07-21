public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string returnString = strs.Length > 0 ? strs[0] : "";

        for (int i = 0; i < strs.Length - 1; i++)
        {
            returnString = GetCommonPrefix(returnString, strs[i + 1]);
            if (returnString.Length == 0)
            {
                return "";
            }
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        return returnString;
    }

    public string GetCommonPrefix(string firstWord, string secondWord)
    {
        string prefix = "";

        for (int i = 0; (i < firstWord.Length) && (i < secondWord.Length); i++)
        {
            if (firstWord[i] == secondWord[i])
            {
                prefix += firstWord[i];
            }
            else
            {
                break;
            }
        }

        return prefix;
    }
}