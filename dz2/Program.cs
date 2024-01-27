// Задача 2: Напишите программу вычисления функции Аккурмана с помощью рекурсии. Даны два неотрицательных числа m и n.

// *Пример*  
// m = 2, n = 3 -> A(m, n) = 29 

int AkkermanFunction(int m, int n){
    if (m == 0){
        int res = n + 1;
        return res;
    }
    if (n == 0){
        return AkkermanFunction(m -1, 1);
    }
    return AkkermanFunction(m-1, AkkermanFunction(m, n - 1));
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(AkkermanFunction(m, n));

