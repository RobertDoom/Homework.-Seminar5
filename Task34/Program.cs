// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] headArray = CreateArray();
Console.Write(String.Join(", ", headArray));
int amountNumbers = EvenFromArray(headArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {amountNumbers}");

int[] CreateArray()
{
    int[] array = new int[8];
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(100, 1000);
    }
    return array;
}

int EvenFromArray(int[] arr)
{
    int amountNumbers = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            amountNumbers = amountNumbers + 1;
        }
    }
    return amountNumbers;
}