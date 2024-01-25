// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.  
// Использовать рекурсию, не использовать циклы.

// *Пример*  
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 

Console.Clear();

void NaturalNambers(int m, int n){
    if (m == n + 1){
        return;
    }
    Console.Write(m + " ");
    NaturalNambers(m + 1, n);
}

NaturalNambers(15, 25);