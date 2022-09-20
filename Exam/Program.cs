// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 ссимвола. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

const int SEARCHED_LENGTH = 3;

Console.WriteLine();
Console.WriteLine("Исходный массив:");
string[] baseArray = {"hello", "2", "world", ":-)"};
Console.WriteLine("[" + string.Join(", ", baseArray) + "]");
Console.WriteLine();
int newArrLength = GetNewArrayLength(baseArray, SEARCHED_LENGTH);
string[] newArr = GetFilteredArray(baseArray, SEARCHED_LENGTH, newArrLength);

Console.WriteLine($"Отфильтруем строки длиной не более {SEARCHED_LENGTH} символов" );
Console.WriteLine("Результирующий массив:");

Console.WriteLine("[" + string.Join(", ", newArr) + "]");
Console.WriteLine();


int GetNewArrayLength(string[] baseArray, int len)
{
    int nl = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length <= len)
            nl = nl + 1;
    };
    return nl;
};

string[] GetFilteredArray(string[] baseArray, int len, int newArrLen)
{
    string[] newArr = new String[newArrLen];
    for (int i = 0, j = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length <= len)
            {
                newArr[j] = baseArray[i];
                j++;
            }
    };
    return newArr;
};