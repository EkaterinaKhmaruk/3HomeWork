/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/

int x1 = ReadInt("Введите точку х1: ");
int y1 = ReadInt("Введите точку y1: ");
int z1 = ReadInt("Введите точку z1: ");
int x2 = ReadInt("Введите точку x2: ");
int y2 = ReadInt("Введите точку y2: ");
int z2 = ReadInt("Введите точку z2: ");

int rast1 = x1 - x2;
int rast2 = y2 - y1;
int rast3 = z2 - z1;
double gipot = Math.Sqrt(rast1*rast1 + rast2*rast2 + rast3*rast3);
Console.WriteLine(gipot);

int ReadInt(string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());

    }

