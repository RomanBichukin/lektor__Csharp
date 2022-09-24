//переписывам предыдущий код с использование генератора
//случайных чисел
//
void FillArray(int[] collection)        //заполняем массив случайными числами
{
    int length = collection.Length;  //получаем длину массива
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);   //заполняем "collection" случайными
        index++;    // index = index + 1                  числами от "1"  до "10"
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];    //в массиве array по умолчанию, будет 10 элементов.
                            //по умолчанию, заполнится нулями.

FillArray(array);         //          
PrintArray(array);        //


