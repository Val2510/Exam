string[] ArrayRand = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите строку первичного массива №{0}:\r\n    ", i + 1);
    ArrayRand[i] = Console.ReadLine()!;
}

string[] Characters(string[] ArrayRand)
{
    int a = 0;
    for (int i = 0; i < ArrayRand.Length; i++)
    {
        if (ArrayRand[i].Length <= 3)
            a++;
    }
    string[] result = new string[a];
    int b = 0;
    for (int i = 0; i < ArrayRand.Length; i++)
    {
        if (ArrayRand[i].Length <= 3)
        {
            result[b] = ArrayRand[i];
            b++;
        }
    }
    return result;
}

void PrintArray(string [] ArrayRand)
{
    for (int i = 0;i<ArrayRand.Length;i++)
    {
    Console.Write($"{ArrayRand[i]},");
    }
    Console.Write(" ");
}

PrintArray(Characters(ArrayRand));
