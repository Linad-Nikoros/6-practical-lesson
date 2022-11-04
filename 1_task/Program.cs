// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите кол-во чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[number];

for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if(array1[i]>0) count=count+1;
}
Console.Write($"Количетсво числе больше 0 равно: {count}");