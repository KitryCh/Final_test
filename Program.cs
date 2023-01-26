string[] FindNumbOfSymb(string[] array)
{
    int j = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) j++;
    }
    string[] result = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}
// Console.WriteLine(String.Join(", ", FindNumbOfSymb(new string[] {"hello", "2", "world", ":-)"})));
// Console.WriteLine(String.Join(", ", FindNumbOfSymb(new string[] {"1234", "1567", "-2", "computer science"})));
Console.WriteLine(String.Join(", ", FindNumbOfSymb(new string[] {"Russia", "Denmark", "Kazan"})));