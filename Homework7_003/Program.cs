// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

void SmallestString (int[,]array)
{
    Console.WriteLine();
    int n=array.GetLength(0);
    int[]rez=new int[n]; 
    int min=0;
    int k=1;

        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            { 
                rez[i]=rez[i] + array[i,j];
                k=i;
            }
            Console.Write(rez[i]+"-"+(k+1)+"  ");   
        }

        Console.WriteLine();

        min=rez[0];

        for(int i=0; i<rez.Length; i++)
        {
            if(min>rez[i])
                min=rez[i];
        }

    Console.WriteLine();

        for(int i=0; i<rez.Length; i++)
            if(min==rez[i])
                Console.WriteLine(" строка с наименьшей суммой элементов найденa, значение элементов - "+ min +" строка №  "+ (i+1));

}

Console.WriteLine();
int m=ReadInt();
int n=ReadInt();
Console.WriteLine();

int[,]array=new int[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SmallestString(array);
Console.WriteLine();

