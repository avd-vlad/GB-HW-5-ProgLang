/*----------------------------------------------------------------------------------
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
----------------------------------------------------------------------------------*/
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

int FindEvenQty(int[] arr)
{
    int qty=0;
    foreach(int x in arr)
        if(x % 2 == 0) qty++;
    
    return qty;
}

int[] arr = CreateRandomArray(10,100,999);
ShowArr(arr);
Console.WriteLine($"Количество чётных чисел в массиве: {FindEvenQty(arr)}");