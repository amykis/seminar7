// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца.  
// Использовать рекурсию, не использовать циклы.

// *Пример*   
// [1,  2, 5, 0, 10, 34] => 34 10 0 2 21

Console.Clear();

// Функция получения массива случайных чисел от 0 до 9.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 99 + 1);
    }
    return array;
}

// Функция рекурсии

void ReverseArray(int [] array, int index){
    if (index == 0){
        return;
    } 
    index--;  
    Console.Write(array[index] + " ");   
    ReverseArray(array, index);
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateRandomArray(size);

// Вывод массива в консоль

for ( int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int index = array.Length;
ReverseArray(array, index);