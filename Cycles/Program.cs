// Циклы:

// 1. For(Для)
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);

// Цикл в цикле:
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine(); //переход на новую строку
}

