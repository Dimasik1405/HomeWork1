
class sistem 
{
    static void Main(string [] arg)
    {
        char [,] array = new char[,]
        {
            {'a', 'd', 'x'},
            {'A', 'V', 'P'},
            {'E', '1', '0'}
        };
    string result = CreateRowFromMatrix(array);
    Console.WriteLine(result);
    }
    static string CreateRowFromMatrix(char[,] array)
    {
        string str = " ";
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                str+= array[i, j];
            }
        }
        return str;
    }

}
