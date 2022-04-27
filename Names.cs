public static class Names
{
    public static readonly string[] _FirstNames =
    {
        "Al", "Amy", "Amanda", "Aiden",
        "Bob", "Bill", "Beatrice", "Betty", "Barbara",
        "Charles", "Chelsea", "Chandra", "Chester", "Corey",
        "Dave", "Donald", "Dina", "Doris",
        "Evan", "Emma"
    };

    public static readonly string[] _LastNames =
        {
        "Abernathy",
        "Einstein",
        "Gates", "Gonzalez",
        "Lopez",
        "Martinez","Musk",
        "Nolan",
        "Oppenheimer",
        "Torvalds", "Turing",
        "Zhukov"
    };

    static System.Random random = new System.Random();

    public static string RandomFirstName() => _FirstNames[random.Next(0, _FirstNames.Length)];
    public static string RandomLastName() => _LastNames[random.Next(0, _LastNames.Length)];

    public static string RandomFullName() => RandomFirstName() + " " + RandomLastName();
}
