// Задайте массив заполненный случайными положительными трёхзначными числами.  Напишите программу, которая покажет количество чётных чисел в массиве. 

int length = ReadInt("размер массива");
int[] array = GetRandomArray(length, 100, 1000);

PrintArray(array);
Console.WriteLine();
CountEven(array);

int ReadInt(string argument)
{
	Console.Write($"введите {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

void CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) {count++;}
    }
    Console.WriteLine($"количество четных чисел в массиве: {count}");
}