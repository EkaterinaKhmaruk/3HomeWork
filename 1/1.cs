/* Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.*/

bool correct = false;

while(!correct)
{
    Console.WriteLine("Введите пятизначное число: ");
    string? number = Console.ReadLine();
    char[] str = number!.ToCharArray();
    int size = str.Length;

    if (size != 5)
    {
        Console.WriteLine("Число не пятизначное... ");
    }
    else
    {
        correct = true;
        string str2 = new string(str);
        Array.Reverse(str);
        string str1 = new string(str);
        Console.WriteLine("Перевернутое число: " + str1);

        if (str1 == str2)
        {
            Console.WriteLine("Число является полиндромом");
        }
        else
        {
            Console.WriteLine("Число не является полиндромом");
        }
    }

   
}