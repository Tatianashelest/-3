Console.WriteLine ("Введите число N..."); 
int N = Convert.ToInt32(Console.ReadLine()); 
int[] array; 
int length = N; 
array = new int[length]; 
 
void FillArray (int[] collection) 
 
{ 
    int length = collection.Length; 
    int index = 0; 
    while (index<length) 
    { 
        collection [index] = index + 1; 
        index ++; 
    } 
} 
 
void PrintArray (int[] print) 
{ 
    int count = print.Length; 
    int position = 0; 
    while (position<count) 
    { 
        Console.WriteLine (print[position]*print[position]*print[position]); 
        position ++; 
    } 
} 
 
FillArray (array); 
PrintArray (array);