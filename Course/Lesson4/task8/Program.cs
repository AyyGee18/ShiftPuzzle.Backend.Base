﻿namespace task8;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int max = numbers[0];
        int min = numbers[0];
        
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n; 
            }
             if (n < min)
            {
                min = n; 
            }
        }
        
        
        Console.WriteLine("Максимальный элемент в массиве: " + max);
        Console.WriteLine("Минимальный элемент в массиве: " + min);
    }
}

