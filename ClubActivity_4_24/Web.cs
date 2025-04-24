namespace ClubActivity_4_24;

internal static class Web
{
    private static readonly HttpClient _shared = new();
    public static string RequestString(string url)
    {
        try
        {
            return _shared.GetStringAsync(url).Result;
        }
        catch
        {
            return string.Empty;
        }
    }
}