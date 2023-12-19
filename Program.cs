// // Напишите программу, которая на вход принимает позиции элемента 
// //в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];
// Console.Write("Введите позицию строки: ");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// Console.WriteLine();
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.Next(0,11);
// Console.Write($"{randomArray[i,j]} ");
// }
// Console.WriteLine();
// }
// }
// mas(m,n);
// if (m2<1 || n2<1)
// Console.Write("Позиции строк не могут быть отрицательными");
// else if (m2 <= m+1 && n2 <= n+1)
// Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]} ");
// else Console.Write("Такого элемента нет в массиве");

// Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.


// int[,] array = new int[3,4];
// // double [] array2 = new double[array.GetLength(0)];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// // void FindElementsArray()
// // {
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         double sumElement=0;

// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
            
// //                sumElement += array[i,j];
// //             // sumElement= sumElement+ array[i,j];

            
// //         }
// //         array2[i] = sumElement/array.GetLength(1);
// //     }
// // }

// // void PrintArray2()
// // {
// //     for (int i = 0; i < array2.Length; i++)
// //     {
        
// //             System.Console.Write(array2[i] + " ");
// //     }
// //     System.Console.WriteLine();
// // }

// // CreateArray();
// // PrintArray();

// void ChangeArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   
//             if (i >= 0 && i < array.GetLength(1))
//             {
//                 int temporary = array[i, j];
//                 array[i, j] = array[i, j];
//                 array[i, j] = temporary;          
//             }
//             else
//             {
//                 int temporary = array[i, j];
//                 array[i, j] = array[(array.GetLength(1) - 1), j];
//                 array[(array.GetLength(1) - 1), j] = temporary;
//             }
//         }
//     }
// }
// void PrintArray2()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// CreateArray();
// PrintArray();
// ChangeArray();
// PrintArray2();

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

int[,] array = new int[4,2];

int sumInMin=100;
int indexMin=0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum=0;

   for (int j = 0; j < array.GetLength(1); j++)
   {
     array[i,j] = new Random().Next(0,10);
     System.Console.Write(array[i,j]+ " ");

     sum += array[i,j];
   }
    System.Console.WriteLine("сумма "+sum);

   if(sum<sumInMin)
   {
     sumInMin= sum;
     indexMin= i;
   }

   System.Console.WriteLine();
}

System.Console.WriteLine("\nИндекс минимальной = "+indexMin);