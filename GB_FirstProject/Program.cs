//Написать программу, которая из имеющегося массива строк формирует
//массив строк, не превышающих в длину трех символов. 

//Метод читает и возвращает строку
string ReadDataString(string msg)
{
    Console.WriteLine(msg);
    string index = Console.ReadLine() ?? "0";
    return index;
}

//Метод преобразует строку в строковой массив
string[] StringArray(string message)
{
    string[] words = message.Split(',');
    foreach (var word in words)
    {
        System.Console.WriteLine($"{word}");
    }
    return words;
}

string[] words = StringArray
(ReadDataString("Введите через запятую слюбые строки: "));