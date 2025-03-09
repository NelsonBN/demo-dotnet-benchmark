namespace Demo;

public static class Helper
{
    public static string StringJoin(string str1, string str2)
    {
        return string.Join(" ", str1, str2);
    }

    public static string StringConcat(string str1, string str2)
    {
        return string.Concat(str1, " ", str2);
    }
}
