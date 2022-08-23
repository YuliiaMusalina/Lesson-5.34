// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 15;
int[] numbers = new int[size];
int result = 0;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] %2 == 0)
        
        {
            result++;
        }
    
}
Console.WriteLine($"Количесво четных чисел в массиве {result}: ");


void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
