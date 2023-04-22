int[] Pop(int[] o) // Создаем функцию и принимаем массив на вход
{
    int g = 0;
    int j;
    
    for (int i = 0; i < o.Length; i++)
    {
        if (o[i] != 0)
        {
            j = o[i];
            o[i] = g;
            o[g] = j;
            g++;
        }
    }

    for (int i = o.Length - 1; i >= g; i--)
    {
        o[i] = 0;
    }
    return o;
}

int[] ints = new int[9] { 5, 4, 0, 0, 2, 2, 0, 3, 0};
Pop(ints);

Console.WriteLine(string.Join(", ", ints));