namespace ClubActivity_4_24;

class Program
{
    static void Main(string[] args)
    {
        string url = "https://en.wikipedia.org/wiki/C_Sharp_(programming_language)";
        string article = Web.RequestString(url);

        Console.WriteLine(article);

        // Look on here for more APIs
        // https://github.com/public-apis/public-apis

        Console.ReadLine();
        Console.Clear();

        // Use api to check if number is even
        // https://isevenapi.xyz/
        int numberToCheck = 47;

        string url2 = "https://api.isevenapi.xyz/api/iseven/" + numberToCheck;

        string isEven = Web.RequestString(url2);

        Console.Write(isEven);
    }
}