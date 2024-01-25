// Задача 1: Напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифр.

// Указание
// Использовать рекурсию.

// 1234 => 10

Console.Clear();

int SumDigits(int num){
    if (num == 0){
        return 0;
    }
     int res = num % 10 + SumDigits(num / 10);
     return res;
}

Console.Write(SumDigits(1234));
Console.WriteLine();


// Задача 2: Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от 1 до N.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример

// N = 5  =>  1  2 3 4 5 


void WriteDigits(int num){
    if (num == 0){
        return;
    }
    WriteDigits(num - 1);
    Console.Write(num + " ");
}

WriteDigits(5);
Console.WriteLine();


// Задача 3: Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример

// hello => h l l
// World => W r l d
// Hello world! => H l l w r l d

void  PrintConsonants(string str){
    if (str.Length == 0){
        return;
    }

    string vovels = "aeiuyo";
    if (char.IsLetter(str[0]) && !vovels.Contains(char.ToLower(str[0]))){
        Console.Write(str[0] + " ");
    }
    PrintConsonants(str.Substring(1));
}

PrintConsonants("Hello!");

// char b = 'a';
// char.IsLetter(n); проверяет является ли буквой
// char.ToLower(n); нижний регистр
// string str = "1234";
// str.Substring(1); Обрезает первый символ
// Функция Аккермана https://site.ada.edu.az/~medv/acm/Docs%20e-olimp/Volume%2012/1111.htm