// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int length = ReadInt("размер массива");
int[] array = GetRandomArray(length, 100, 500);

PrintArray(array);
Console.WriteLine();
SumOfElementsOddPosition(array);

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

void SumOfElementsOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"сумма элементов, на нечетных позициях: {sum}");
}
