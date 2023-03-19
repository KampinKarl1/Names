public static class Names
{
    public static readonly string[] _FirstNames =
    {
        "Al", "Amy", "Amanda", "Aiden",
        "Bob", "Bill", "Beatrice", "Betty", "Barbara",
        "Charles", "Chelsea", "Chandra", "Chester", "Corey",
        "Dave", "Donald", "Dina", "Doris",
        "Evan", "Emma",  "Liam", "Noah", "Oliver", "Ethan", "Aiden", "Lucas", "Mason", "Logan", "Caleb", "Elijah",
        "Declan", "Finn", "Liam", "Ronan", "Seamus", "Ciaran", "Aisling", "Bridget", "Saoirse", "Niamh",
        "Diego", "Alejandro", "Carlos", "Santiago", "Isabella", "Sofia", "Juan", "Miguel", "Emilia", "Valeria",
        "Pierre", "Lucien", "Gaston", "Aurelie", "Camille", "Julien", "Claire", "Sophie", "Antoine", "Gabriel",
        "Mateusz", "Jakub", "Kacper", "Lena", "Alicja", "Oskar", "Karol", "Maja", "Julia", "Kuba",
        "Haruka", "Aiko", "Yuki", "Akira", "Kenji", "Hana", "Sora", "Kai", "Jin", "Naoki",
        "Alofa", "Lauli'i", "Pili", "Leilani", "Kai", "Kiana", "Malie", "Moana", "Nalani", "Alohi"
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
        "Zhukov", "Smith", "Johnson", "Brown", "Jones", "Garcia", "Miller", "Davis", "Martinez", "Gonzalez", "Lopez",
        "Schmidt", "Müller", "Schneider", "Fischer", "Weber", "Bauer", "Richter", "Schulz", "Kowalski", "Nowak",
        "O'Reilly", "Murphy", "Kelly", "Sullivan", "O'Connor", "Gallagher", "Kennedy", "Ryan", "Fitzgerald", "Doyle",
        "Gonzalez", "Rodriguez", "Hernandez", "Martinez", "Perez", "Sanchez", "Gomez", "Flores", "Diaz", "Reyes",
        "Lee", "Kim", "Choi", "Park", "Sato", "Suzuki", "Yamamoto", "Tanaka", "Lam", "Nguyen",
        "Smith", "Brown", "Johnson", "Jones", "Williams", "Davis", "Miller", "Wilson", "Moore", "Taylor"
    };

    static System.Random random = new System.Random();

    public static string RandomFirstName() => _FirstNames[random.Next(0, _FirstNames.Length)];
    public static string RandomLastName() => _LastNames[random.Next(0, _LastNames.Length)];

    public static string RandomFullName() => RandomFirstName() + " " + RandomLastName();
    public static string RandomSpanishFormatName()=> RandomFirstName() + " " + RandomLastName() + " " + RandomLastName();
}
