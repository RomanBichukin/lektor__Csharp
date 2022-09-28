// ЦИКЛ В ЦИКЛЕ....вывод таблицы умножения на экран:
/* 
for (int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();        //для интервала между столбиками...
} */
//===============================================================
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//===============================================================
//Дан текст.В тексте все пробелы заменить черточкой, маленькие буквы "к" заменить большими "К",
//а большие "С" маленькими:

/* Console.Clear();
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
//             012345 
// string s = "qwerty"
//s[3] -> "r"

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText); */

//===========================================================================
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//===========================================================================
//ФУНКЦИИ в програмировании:
//Было: 6 8 3 2 1 4 5 7
//Стало:1 2 3 4 5 6 7 8
//1.Найти поз-ю мин-го эл-та в неотсорт-й части массива
//2.Произвести обмен этого знач-я со знач-ем первой неотсорт-й поз-и
//3.Повторять пока есть неотсорт-е эл-ты
Console.Clear();
//заводим массив, который можно отсорт-ть:
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
//подзадача: метод, чтобы вывести наш метод на экран
//1-й способ:
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//PrintArray(arr);

// Пишем метод, который будет упорядочивать на массив:
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        //
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);