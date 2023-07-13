/* 
Задача 55: Задайте двумерный массив.  
Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя. 
*/ 
 
int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            array[i,j] = rand.Next(min,max+1); 
        } 
    } 
    return array; 
} 
 
void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 
 
int [,] SwithRowsCols(int [,] array){ 
    int [,] array2 = new int [array.GetLength(0),array.GetLength(1)];  
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array2[i,j] = array [j,i]; 
             
        } 
        Console.WriteLine(); 
    } 
    return array2; 
} 
 
bool CheckMatrix (int [,] array){ 
    if(array.GetLength(0) == array.GetLength(1)) 
        return true; 
    else  
        return false; 
} 
 
Console.Clear(); 
int [,] array = CreateArray(5,6,0,10); 
PrintArray(array); 
Console.WriteLine(); 
if(CheckMatrix(array)){ 
    array = SwithRowsCols(array); 
PrintArray(array); 
} 
else 
    Console.WriteLine("This matrix is not switchable");