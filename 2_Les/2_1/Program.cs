﻿// Напишите программу, которая выводит случайное трехзначное число и на выходе показывает его последнюю цифру

//
int Num(int num)
{

    return num %10;
}

Console.WriteLine(Num(new Random().Next(10,1000)));
