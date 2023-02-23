// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
void ArithmeticMean (int[,]array)
{
    Console.WriteLine();
    int n=array.GetLength(1);
    int[]rez=new int[n]; 
    int k=1;

        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int i=0; i<array.GetLength(0); i++)
            { 
                rez[j]=rez[j] + array[i,j];
                k=i+1;
            }
            Console.Write($"{rez[j]}\t");   
        }

        Console.WriteLine();

        for(int i=0; i<rez.Length; i++)
        {
            rez[i]=rez[i]/k;                           // если нужно десятичное значение, необходимо заменить 
            Console.Write($"{rez[i]}\t");              // тип значения с Int на Double.
        }
        Console.WriteLine();
}

Console.WriteLine();
int m=ReadInt();
int n=ReadInt();
Console.WriteLine();

int[,]array=new int[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ArithmeticMean(array);
Console.WriteLine();