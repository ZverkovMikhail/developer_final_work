// ====================================================================
// Программа, из имеющегося массива строк формирует массив из строк, 
// длинна которых равна либо меньше 3 символа
// ====================================================================


// Чтение данных
string[] ReadData(string text)
{
    Console.WriteLine($"{text}:");
    return Console.ReadLine().Split(",").Select(p => p.Trim()).ToArray();
}


// Возвращает массив строк длинна которых равна либо меньше charCount
string[] EqualOrLessChar(string[] array, int charCount)
{
    string[] buf = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= charCount)
        {
            Array.Resize(ref buf, buf.Length + 1);
            buf[buf.Length - 1] = array[i];
        }
    }
    return buf;
}


// Печать массива
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


PrintArray(
    EqualOrLessChar(
        array: ReadData("Введите элементы массива через запятую"),
        charCount: 3
    )
);