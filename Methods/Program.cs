// Методы:

// 1. Ничего не принимают и ни чего не возвращают.
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

//3.Ни чего не возвращают, но могут принимать какие-нибудь аргументы.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method1(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
//Method21(count: 4, msg: "Новый текст"); //Явно указываем к какому аргументу 
// какое значение мы присваиваем, в любом порядке

// 3.Что то возвращают, но ничего не принимают.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// 4. Что-то принимают и что-то возвращают.
string Method4(int count, string text) // функция будет вызывать строку
{
    int i=0;
    string result = String.Empty; // переменная в которую будем класть конечный результат = пустая строка

    while(i<count)
    {
        result = result +text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
