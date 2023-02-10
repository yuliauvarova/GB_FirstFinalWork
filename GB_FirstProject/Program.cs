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

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод считает число строк нужной длины
int CountLines(string[] arr,int maxSize)
{
    int countLines =0;
    for(int i=0;i<arr.Length; i++)
    {
        if(arr[i].Length<=maxSize)
        {
            countLines=countLines+1;
        }
    }
    return countLines;
}

//Метод включает в массив только строки определенной длины
string[] ReducedArray(string[] arr, int countLines, int maxSize)
{
    string[] newArr = new string[countLines];
    int position=0;
        for(int j=0; j<arr.Length; j++)
        {
            if(arr[j].Length<=maxSize)
            {
                newArr[position] = arr[j];
                position = position+1;
            }
        }
        return newArr;
}

//Метод выводит на экран массив
void Print1DArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

string[] words = StringArray(ReadDataString("Введите через запятую слюбые строки: "));
Console.WriteLine();
int maxSize = ReadData("Введите максимальное число символов, которое должна содержать строка нового массива: ");
int countLines = CountLines(words, maxSize);
string[] newArr = ReducedArray(words, countLines, maxSize);
Console.WriteLine();
Print1DArray(newArr);



