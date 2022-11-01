//Вид 1

//void Metod1 ()
//{
//    Console.WriteLine("Автор ... ");
//}
//Metod1();
 

//Вид 2

//void Metod2 (string msg)
//{
//    Console.WriteLine(msg);
//}
//Metod2 ("Текст");


//void Metod21 (string msg, int count)
//{
//   int i = 0;
//    while (i <count)
//    {
//        Console.WriteLine(msg);
//        i++;
//    }    
//}
//Metod21 (msg: "Текст", count: 4);


//Вид 3

//int Metod3()
//{
//    return DateTime.Now.Year;
//}

//int year = Metod3;
//Console.WriteLine(year);

//Вид 4

int Metod4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Metod4(10, 'sdf');
Console.WriteLine(res);