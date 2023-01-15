// //Viod - функция(метод), которая не возвращает значения; FillArray - название метода; (int[] collection) - аргумент(переменная)
// void FillArray(int[] collection)//<---Функция заполнения массива(Fill - заполнить)
// {
//     int length = collection.Length;//длина массива
//     int index = 0;//позиция по умолчанию
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);//Заполнение массива из диапозона 1-10
//         index++;
//     }
// }

// void PrintArray(int[] col)//<--- Метод печати массива
// {
//     int count = col.Length;//<---- кол-во элементов массива
//     int position = 0;//<---- позиция по умолчанию
//     while (position < count)//<---- "Пока позиция больше длины массива - в консоль будет печататься
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }


// // Создай массив из 10 элементов(по уолчанию заполнен нулями)
// int[] array = new int[10];

// FillArray(array);//<---- Вызов метода Заполнения массива 
// PrintArray(array);//<---- Вызов метода Печати массива в консоль






//Viod - функция(метод), которая не возвращает значения; FillArray - название метода; (int[] collection) - аргумент(переменная)
void FillArray(int[] collection)//<---Функция заполнения массива(Fill - заполнить)
{
    int length = collection.Length;//длина массива
    int index = 0;//позиция по умолчанию
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);//Заполнение массива из диапозона 1-10
        index++;
    }
}

void PrintArray(int[] col)//<--- Метод печати массива
{
    int count = col.Length;//<---- кол-во элементов массива
    int position = 0;//<---- позиция по умолчанию
    while (position < count)//<---- "Пока позиция больше длины массива - в консоль будет печататься
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

//Метод поиска нужного элемента массива и печать его индекса в консоль
int IndexOf(int[] collection, int find)
{
    //Задаем переменные
    int count = collection.Length;
    int index = 0;
    int position = -1;//Если нужного элемента нет в массиве, в консоль будет печататься  -1
    
    while (index < count)//Перебираем массив
    {
        if (collection[index] == find)//Нахождение нужного элемнета
        {
            position = index;
        }
        // index = index + 1;
        index++;
    }
    return position;
}

// Создай массив из 10 элементов(по уолчанию заполнен нулями)
int[] array = new int[10];//Условие задачи(Задаем массив из 10-ти эмлементов)

FillArray(array);//<---- Вызов метода Заполнения массива 
PrintArray(array);//<---- Вызов метода Печати массива в консоль
Console.WriteLine();//Добавление пустой строки

int pos = IndexOf(array, 5);//<----Вызываем метод поиска нужного элемента массива(array - наш заданный массив; "4" - Find)
if (pos == -1)
{
    Console.WriteLine("Нет нужного элемента в массиве");
}
else
Console.WriteLine(pos);//<---- Печать в консоль индекса нужного элемента массива