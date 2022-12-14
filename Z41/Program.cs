/*                          Домашнее задание к семинару 6 С#
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Например:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3             */

 void CountPozitiveNubmers()
{
    try
    {
        Console.WriteLine("Введите любые целые числа разделённые пробелом. Когда закончите, нажмите Enter");
        int[] array = Array.ConvertAll
            ((Console.ReadLine()).Split(' '), int.Parse);
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) count++;
        }
        Console.WriteLine("Введено положительных чисел: " + count);
    }
    catch
    {
        Console.WriteLine("Ошибка: некорректный ввод!");
    }
}

CountPozitiveNubmers();