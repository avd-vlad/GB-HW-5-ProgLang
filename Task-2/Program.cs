int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] newArr=new int[size];

    for(int i=0; i<size; i++)
        newArr[i]= new Random().Next(minVal,maxVal+1);

    return newArr;
}

void ShowArr(int[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int SumOddPos(int[] arr)
{
    int sum=0;
    for(int i = 1; i < arr.Length; i+=2)
        sum+=arr[i];
    
    return sum;
}

int[] arr = CreateRandomArray(4,100,999);
ShowArr(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumOddPos(arr)}");