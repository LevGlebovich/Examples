﻿//Функция(метод) возвращаемого типа
int Max(int arg1, int arg2, int arg3)
{
//  Сравнение и определение максимального зачения из 3-х
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;//<==== Сохранение результата вычислений в методе
}
//индексы массива(счт начинается с нуля)     
//               0   1    2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };



int max = Max(
    Max(array[0], array[1], array[2]),//<====сравнение первых 3-х индексов массива
    Max(array[3], array[4], array[5]),//<====сравнение вторых 3-х индексов массива
    Max(array[6], array[7], array[8])//<====сравнение последних 3-х индексов массива
);
System.Console.WriteLine(max);