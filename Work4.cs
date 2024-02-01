class Task4
{
static void Main(string[] arg)
{
    string input = "Hello my world";
    string result = ReversString(input);
    Console.WriteLine(result);
}
    static string ReversString(string str)
    {
        string[] definit = str.Split(' ');
        Array.Reverse(definit);
        return string.Join(" ", definit);
    }
}
