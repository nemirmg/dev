// Быстрая сортировка O(log2(n) * n)

// Напишите программу, которая сложит 2 числа a и b без прямого сложения.
// Рекурсия

// int sumNumbers(int n, int m){
//     if (m == 0)
//         return n;
//     return sumNumbers(n + 1, m - 1);
// }
/*
f = sumNumbers

f(5, 3) -> f(6, 2) -> f(7, 1) -> f(8, 0) -> 8
*/
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {sumNumbers(a, b)}");

/*
1) array = [7, 4, 1, 3, 5, 2, 8, 6]
   pivot = array[0] = 7 -> выбираем опорный элемент - например, первый

вначале выбираем элементы строго меньше опорного (порядок не меняем):
[4, 1, 3, 5, 2, 6]

затем выбираем элементы равные опорному:
[7]

и наконец выбираем элементы строго большие опорного:
[8]

Получаем:
[4, 1, 3, 5, 2, 6] + [7] + [8]

2) Повторяем все операции заново для левого массива:
array = [4, 1, 3, 5, 2, 6]
pivot = 4
[1, 3, 2] + [4] + [5, 6]

3) и ещё раз:
array = [1, 3, 2]
pivot = 1
[] + [1] + [3, 2]

4) т.к. левый массив пустой - берём правый:
array = [3, 2]
pivot = 3
[2] + [3] + []

5) также нужно отсортировать правый массив из шага 2):
array = [5, 6]
pivot = 5
[] + [5] + [6]

в итоге первоначальное разложение преобразуется в:
[4, 1, 3, 5, 2, 6] + [7] + [8] = [] + [1] + [2] + [3] + []
+ [4] + [] + [5] + [6] + [7] + [8]
*/

/*
Структура кода:
импорт всех модулей/библиотек/объектов

Объекты и методы
функции и процедуры
основной программный код
*/
// функция для соединения массивов
T[] Concat<T>(params T[][] arrays){ // [1, 2, 3] [4, 5] [6, 7, 8, 9]
    var result = new T[arrays.Sum(a => a.Length)]; // [0, 0, 0, 0, 0, 0, 0, 0]
    int offset = 0;
    foreach (T[] array in arrays){
        array.CopyTo(result, offset); // [1, 2, 3, 0, 0, 0, 0, 0]
        offset += array.Length; // offset = 0 + 3 = 3
    }
    return result;
}

// функция быстрой сортировки
int[] quickSort(int[] array){
    if (array.Length < 2)
        return array;
    else{
        int pivot = array[0];
        
        // подсчёт элементов меньше опорного
        int count = 0;
        for (int i = 1; i < array.Length; i++){
            if (array[i] < pivot)
                count++;
        }
        // создание массива для элементов < опорного
        int[] less = new int[count];
        int j = 0;
        for (int i = 1; i < array.Length; i++){
            if (array[i] < pivot){
                less[j] = array[i];
                j++;
            }
        }
        
        // подсчёт элементов больше опорного
        count = 0;
        for (int i = 1; i < array.Length; i++){
            if (array[i] > pivot)
                count++;
        }
        // создание массива для элементов > опорного
        int[] greater = new int[count];
        j = 0;
        for (int i = 1; i < array.Length; i++){
            if (array[i] > pivot){
                greater[j] = array[i];
                j++;
            }
        }
        
        // подсчёт элементов равных опорному
        count = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] == pivot)
                count++;
        }
        // создание массива для элементов = опорному
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++){
            pivotArray[i] = pivot;
        }
        // объединение всех массивов
        int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
        return result;
    }
}

Console.Clear();
int[] array = {7, 4, 1, 3, 5, 2, 8, 6};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array))}]");