/* 
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
Набор данных 
Частотный массив 
{ 1, 9, 9, 0, 2, 8, 0, 9 } 
0 встречается 2 раза  
1 встречается 1 раз  
2 встречается 1 раз  
8 встречается 1 раз  
9 встречается 3 раза 
1, 2, 3  
4, 6, 1  
2, 1, 6 
1 встречается 3 раза  
2 встречается 2 раз  
3 встречается 1 раз  
4 встречается 1 раз  
6 встречается 2 раза 
*/ 
 
/* 
Dictionary<int, string> map = new Dictionary<int, int>() 
{ 
    { 1, 1}, 
    { 2, 2}, 
    { 3, 1}, 
    { 4, "Thursday"}, 
    { 5, "Friday"}, 
    { 6, "Saturday"}, 
    { 7, "Sunday"} 
}; 
*/ 
 
int [] GetMassive(int [,] array){ 
    int size = array.GetLength(0)*array.GetLength(1); 
    int [] array2 = new int [size]; 
    int k = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array2[k] = array[i,j]; 
            k++; 
        } 
    } 
    Array.Sort(array2); 
    return array2; 
} 
 
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
 
Dictionary<int, int> GetFreqDic(int [] array){ 
    Dictionary<int, int> freqDict = new Dictionary<int, int>(); 
    int count = 1; 
    int element = array[0]; 
    for (int i = 1; i < array.Length; i++) 
    { 
        if(array[i] != element){ 
            freqDict.Add(element, count); 
            count = 1; 
            element = array[i]; 
        } 
        else 
            count++; 
    } 
    freqDict.Add(element, count); 
 
    return freqDict; 
} 
 
Console.Clear(); 
int [,] array = CreateArray(5,5,0,10); 
PrintArray(array); 
Console.WriteLine(); 
int [] array2 = GetMassive(array); 
Console.WriteLine(String.Join(", ", array2)); 
Console.WriteLine(); 
Dictionary<int, int> freqDict = GetFreqDic(array2); 
 
foreach (var item in freqDict) 
{ 
    Console.WriteLine($"Number {item.Key}, repeat {item.Value}"); 
}