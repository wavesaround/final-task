Console.Clear();

string[] BuildNewString(string[] Source, int n)
{
    int count = 0;
    for (int i = 0; i < Source.Length; i++)
    {
        if (Source[i].Length <= n)
            count++;
    }

    string[] Result = new string[count];
    for (int i = 0, j = 0; i < Source.Length; i++)
    {
        if (Source[i].Length <= n)
        {
            Result[j] = Source[i];
            j++;
        }
    }

    return Result;
}

string[] First = { "hello", "2", "world", ":-)" };
Console.WriteLine($"[ {string.Join(", ", First)} ] -> [ {string.Join(", ", BuildNewString(First, 3))} ]");