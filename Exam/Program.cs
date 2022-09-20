// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 ссимвола. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine();
Console.WriteLine("Исходный массив:");
string[] baseArray = {"hello", "2", "world", ":-)"};
Console.WriteLine("[" + string.Join(", ", baseArray) + "]");
Console.WriteLine();
int newArrLength = GetNewArrayLength(baseArray, 3);
string[] newArr = GetFilteredArray(baseArray, 3, newArrLength);

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