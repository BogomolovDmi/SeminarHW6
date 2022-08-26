// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите размер массива");
int m = int.Parse(Console.ReadLine()!);

int[] createArray()
{
    int [] result = new int[m];
    
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите символ с индексом {i}");
        result[i] = int.Parse(Console.ReadLine()!);
    }

    return result;
}

int searchNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result += 1;
        }
    }
    return result;
}

void printArray1(int[] array) 
{ 
    Console.Write("["); 
 
    for (var i = 0; i < array.Length; i++) 
    { 
        Console.Write(array[i]); 
 
        if (i != array.Length - 1) 
            Console.Write(", "); 
    } 
 
    Console.Write("]"); 
    Console.WriteLine(); 
} 
Console.WriteLine("Вводите массив по 1 символу");
Console.WriteLine();
var array = createArray(); 
printArray1(array);
int result = searchNumbers(array);
Console.Write(" -> " + result);




