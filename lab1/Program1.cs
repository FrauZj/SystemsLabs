enum ROMAN_LETTERS
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000
}

public class RomanLettersMath
{

    public static void Main()
    {

        Console.WriteLine("Enter first roman value");
        string v1 = Console.ReadLine();
        var get1 = new RomanLettersMath();
        int first = get1.RomanLetterConverter(v1.ToUpper());


        Console.WriteLine("Enter second roman value");
        string v2 = Console.ReadLine();
        var get2 = new RomanLettersMath();
        int second = get2.RomanLetterConverter(v2.ToUpper());

        Console.WriteLine(RomanLetterComparison(first, second));

    }
    public int RomanLetterConverter(string value) 
    {
        Dictionary<string, int> romanLetters = 
        Enum.GetValues(typeof(ROMAN_LETTERS)).Cast<ROMAN_LETTERS>()
        .ToDictionary(letter => letter.ToString(), letter => (int)letter);

        string[] letters = value.Split(" ");
        int convertedEnd = 0;
        foreach (char letter in value)
        {
            string stringLetter = letter.ToString();
            if (romanLetters.ContainsKey(stringLetter))
            {
                int actualValue;
                romanLetters.TryGetValue(stringLetter, out actualValue);
                convertedEnd += actualValue;

            }
        }
        Console.WriteLine(convertedEnd);
        return convertedEnd;
    }
    public static int RomanLetterComparison(int first, int second) 
    { if (first > second) { return 1; } else if (first < second) { return -1; } else { return 0; } }
    
}
