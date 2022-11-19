//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

//Задача 21
/*
void Pol5Dig(int num)
{
    int current = num / 1000; 
    
    if (current / 100 == 0)
    {
        if ((num / 10000) == (num % 10) && (current % 10) == (num % 100) / 10)
        {
            Console.WriteLine($"The number {num} is a polyndrom");
        }
        else Console.WriteLine($"The number {num} is not a polydrome");
    }else Console.WriteLine($"Number {num} is not five digits!");
}

Console.WriteLine("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Pol5Dig(number);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double LongLine(int x1, int y1,int z1, int x2, int y2, int z2)
{
    double lenghtAB = Math.Round(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)), 3);   //функция корень квадратный - Math.Sqrt(...)
    return lenghtAB;
}

Console.WriteLine("input X coordinat of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinat of A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinat of A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input X coordinat of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinat of B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinat of B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"Distanse AB is {dist}");
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


