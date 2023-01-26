// Задача 2: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
//A (3,6); B (2,1) -> 5

void Quarters(string a)
{
    if (a == "I")
        Console.WriteLine("x > 0 and y > 0");
    else if (a == "II")
        Console.WriteLine("x < 0 and y > 0");
    else if (a == "III")
        Console.WriteLine("x < 0 and y < 0");   
    else if (a == "IV")
        Console.WriteLine("x > 0 and y <  0");
    else 
        Console.WriteLine("error");       

}
Quarters(Console.ReadLine());
