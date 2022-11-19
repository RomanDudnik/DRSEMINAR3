//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

//Задача 21

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



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125