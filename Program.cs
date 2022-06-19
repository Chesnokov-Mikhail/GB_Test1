/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/
Console.Clear();
/// <summary>
/// Метод PrintStringArray()
/// выводит в консоль содержимое массива строк
/// </summary>
void PrintStringArray(ref string[] words)
{
    Console.Write("[");
    if (words.Length > 0)
    {
        for(int i = 0; i < words.Length - 1; i++)
            Console.Write(words[i] + ", ");
        Console.Write(words[words.Length - 1]);
    }
    Console.Write("]");
}
/// <summary>
/// Метод ArrayStringLessNumber()
/// возвращает новый массив строк, длина которых меньше либо равна numberWords символа
/// </summary>
/// <param name="words"> исходный массив строк </param>
/// <param name="numberWords"> длина строки в символах </param>
string[] ArrayStringLessNumber(ref string[] words, int numberWords)
{
    string[] newWords;
    string indexStr = String.Empty;
    for(int i = 0; i < words.Length; i++)
        if (words[i].Length <= numberWords)
        {
            indexStr += Convert.ToString(i) + " ";
        }
    string[] indexStrArray = indexStr.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    newWords = new string[indexStrArray.Length];
    for (int j = 0; j < indexStrArray.Length; j++)
    {
        newWords[j] = words[Convert.ToInt32(indexStrArray[j])];
    }
    return newWords;
}
// Берем предложение для формирования массива строк
string lirics ="There's a lady who's sure all that glitters is gold, and she's buying a stairway to heaven When she gets there she knows, if the stores are all closed, with a word she can get what she came for.";
// Формируем исходный массив строк
string[] words = lirics.Split(" ",StringSplitOptions.RemoveEmptyEntries);
// string[] words = {"hello", "2", "world", ":-)"};
// string[] words = {"1234", "1567", "-2", "computer science"};
// string[] words = {"Russia", "Denmark", "Kazan"};
// Формируем новый массив строк, которые меньше либо равна 3 символа
int numberWords = 3;
string[] newWords = ArrayStringLessNumber(ref words, numberWords);
// выводим исходный массив
PrintStringArray(ref words);
Console.Write(" -> ");
// выводим новый массив
PrintStringArray(ref newWords);