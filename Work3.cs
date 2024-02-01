class Programm
{
    static void Main(string[] arg)
    {
        string arbstring = "55655";
        bool isPolidron = IsPolidron(arbstring);
        Console.WriteLine(isPolidron? "Да" : "нет");
    }
    static bool IsPolidron(string str)
    {
        string normal = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return normal.SequenceEqual(normal.Reverse());
    }
}