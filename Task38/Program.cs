//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

double[] headArray = CreateArray();
Console.WriteLine(String.Join(", ", headArray));
double max = MaxSelection(headArray);
double min = MinSelection(headArray);
Console.WriteLine($"Max: {max}, Min: {min}");
Console.WriteLine($"Разница между Max и Min: {Difference(max, min)}");

double[] CreateArray()
{
    double[] array = new double[8];
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 100);
    }
    return array;
}

double MaxSelection(double[] arr1)
{
    double maxResult = 0;
    for(int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i] > maxResult) 
        {
            maxResult = arr1[i];
        }
    }
    return maxResult;
}

double MinSelection(double[] arr2)
{
    double minResult = 100;
    for(int i = 0; i < arr2.Length; i++)
    {
        if(arr2[i] < minResult)
        {
            minResult = arr2[i];
        }
    }
    return minResult;
}

double Difference(double maximum, double minimum)
{
    double Difference = maximum - minimum;
    return Difference;
}
