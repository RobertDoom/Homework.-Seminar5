//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

int[] headArray = CreateArray();
Console.Write(String.Join(", ", headArray));
int sumOfOdd = sumOfOdd1(headArray);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечётных позициях равна = {sumOfOdd}");

int[] CreateArray()
{
    int[] array = new int[8];
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(-100, 100);
    }
    return array;
}

int sumOfOdd1(int[] arr)
{
    int sumOfOdd1 = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sumOfOdd1 = sumOfOdd1 + arr[i];
        }
    }
    return sumOfOdd1;
}