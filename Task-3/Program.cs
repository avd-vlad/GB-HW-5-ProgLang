double[] CreateRandomArray(int size, int minVal, int maxVal)
{
    double[] newArr=new double[size];

    for(int i=0; i<size; i++)
    {
        Random rnd = new Random();
        newArr[i]= rnd.Next(minVal,maxVal+1) + rnd.NextDouble();
    }
    return newArr;
}

void ShowArr(double[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]:f2}]");
        else
            Console.Write($"{arr[i]:f2} ");
    Console.WriteLine();
}

double ArrVariance(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
        if(arr[i] > max) max = arr[i];
    }
    return max-min;
}

double[] arr = CreateRandomArray(10,-100,100);
ShowArr(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {ArrVariance(arr):f2}");