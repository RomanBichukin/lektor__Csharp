/* ФУНКЦИИ В ПРОГРАМИРОВАНИИ */
/* //ВИД 1: ничего не принимают, ничего не возвращают;
    //созидаем метод:
void Method1()
{
    Console.WriteLine("Автор ...");
}
    //вызываем наш метод:
Method1();  //скобки обязательны... */


//ВИД 2: что-то принимают, ничего не возвращают;

/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); */

    //если принимает несколько аргументов:

/* void Method21(string msg, int count);
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;    //инкрименция...иначе декр....
    }
}
//Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст"); */

//ВИД 3: ничего не принимают, что-то возвращают;

/* int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */

//ВИД 4: что-то принимают, что-то возвращают;

/* string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "1+");
Console.WriteLine(res); */

//Цикл "for"
string Method4(int count, string c)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "z ");
Console.WriteLine(res);