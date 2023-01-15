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


// Создай массив из 10 элементов(по уолчанию заполнен нулями)
int[] array = new int[10];

FillArray(array);//<---- Вызов метода Заполнения массива 
PrintArray(array);//<---- Вызов метода Печати массива в консоль