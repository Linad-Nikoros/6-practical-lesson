// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите кол-во чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[number];

for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + " ");
}