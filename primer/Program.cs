// Функции и процедуры (методы???)

// методы - это понятие допустимо только в ООП

// Простая процедура (в отличие от функции НИЧЕГО не возвращает)

// void f() {
//         Console.WriteLine("Hello, world!");
//     }
    
// Console.Clear();
// f();
// f();
// f();

// Процедура принимает аргументы

// передача по значению
// void f(int n){
//     n = n + 5;
// }

// int n = 10;
// f(n);
// Console.WriteLine(n);

// передача по ссылке
// void f(ref int n){
//     n = n + 5;
// }

// int n = 10;
// f(ref n);
// Console.WriteLine(n);

// В отличие от процедуры функция ОБЯЗАНА возвращать какой-то тип данных

// Выведите наибольшее число среди 2-х

// int maxDouble(int x, int y){
//     if (x > y)
//         return x;
//     return y;
// }
// // return - возвращает значение откуда была вызвана функция!!!
// // return - моментально завершает работу функции!!!
// int result = maxDouble(12, 18);
// Console.WriteLine(result);
// Console.WriteLine(maxDouble(-1, 5));
// Console.WriteLine(maxDouble(134, 8));
// Console.WriteLine(maxDouble(-89, 56));

// string maxDouble(int x, int y){
//     if (x > y)
//         return "Первое число больше второго";
//     return "Второе число больше или равно первому";
// }

// string result = maxDouble(12, 18);
// Console.WriteLine(result);
// Console.WriteLine(maxDouble(-1, 5));
// Console.WriteLine(maxDouble(134, 8));
// Console.WriteLine(maxDouble(-89, 56));

//---------------
/*
Задание 1
Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом
массиве.

Примеры:
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3
*/

void inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1001);
}

// простые числа - те, которые НЕ имеют делителей
// в дипазоне [2; n // 2]

bool isPrime(int x){
    for (int i = 2; i <= x / 2; i++){
        if (x % i == 0)
            return false;
    }
    return true;
}

Console.Clear();
Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Простые числа: ");
int count = 0;
foreach (int elem in array){  // таким образом нельзя изменить элементы массива!
    if (isPrime(elem))
        count++;
}
Console.WriteLine(count);
