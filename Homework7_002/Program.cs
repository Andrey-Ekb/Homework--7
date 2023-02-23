// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.Clear();

int ReadInt()
{
    Console.Write("Введите размер массива : ");
    return int.Parse(Console.ReadLine()!);
}

void FillArray (int[,] array)
{
    Random rnd=new Random();
        for (int i=0; i<array.GetLength(0); i++)
        
            for (int j=0; j < array.GetLength(1); j++)
            { 
                array[i,j] = rnd.Next(1,10);
            }
}
void PrintArray (int[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    { 
        for (int j=0; j < array.GetLength(1); j++)
        {     
            Console.Write($"{ array[i,j] }\t ");
        }
        Console.WriteLine();
    }
}

int[,] SortRowAscending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;    
            }
            int tmp = array[i, j];                                          
            array[i, j] = array[i, minPosition];                            
            array[i, minPosition] = tmp;                                    
        }

    }
    return array;
}

Console.WriteLine();
int m=ReadInt();
int n=ReadInt();
Console.WriteLine();

int[,]array=new int[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int[,] rowSort = SortRowAscending(array);
PrintArray(array);
Console.WriteLine();
