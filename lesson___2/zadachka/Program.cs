//Имеется однородный массив array из n элементов, требуется
//найти элемент массива, равный find....

int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length;   //
int find = 4;

int index =0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;      //останавливает цикл при нахождении искомого,
                    //не ищет дальше(похожие)...
    }
   // index = index + 1;
   index++;

}