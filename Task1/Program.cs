// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К", 
// а большие "C" заменить маленькими "c".

string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
// s[3]//r

string Replace(string text, char oldValue, char newValue) // char-символ
{
    string result = String.Empty; // присвоили пустую стороку

    int length = text.Length; //колличество символов в строке
    for (int i = 0; i < length; i++) //пробегаемся до конца строки
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // если текущий символ текста совпал
                                                                  //с тем символом, который мы хотим заменить, то в результат ложим новое значение
        else result = result + $"{text[i]}";//если совпадений не обнаружено,то добавляем в result текущее значение
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К'); //если вместо newText написать text, то изменять будет изночальный текст
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);


