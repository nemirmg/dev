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

// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001);
// }

// // простые числа - те, которые НЕ имеют делителей
// // в дипазоне [2; n // 2]

// bool isPrime(int x){
//     for (int i = 2; i <= x / 2; i++){
//         if (x % i == 0)
//             return false;
//     }
//     return true;
// }

// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Простые числа: ");
// int count = 0;
// foreach (int elem in array){  // таким образом нельзя изменить элементы массива!
//     if (isPrime(elem))
//         count++;
// }
// Console.WriteLine(count);

//---------------
/*
Задание 2
Задайте массив из N случайных чисел (N вводится с клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.

Пример:
[1 5 11 21 81 4 0 91 2 3] => 2
*/

// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(1, 1001);
//     }
// }

// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int count = 0;
// foreach (int element in array){
//     if (element % 10 == 1 && element % 7 == 0)
//         count++;
// }
// Console.WriteLine(count);

//---------------
/*
Задание 3
Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.

Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
*/

// моё решение
// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 10);
// }

// int createNumber(int[] array){
//     int num = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (i == array.Length - i)
//             num += array[i];
//         else {
//             int x = array[i];
//             for (int j = 1; j < array.Length - i; j++)
//                 x *= 10;
//             num += x;
//         }
//     }
//     return num;
// }

// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 8)
// {
//     Console.WriteLine("Чисел должно быть не более 8!");
//     Console.Write("Введите количество чисел: ");
//     n = int.Parse(Console.ReadLine()!);
// }

// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// int result = createNumber(array);
// Console.WriteLine(result);

// решение на семинаре
// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 10);
// }

// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 8)
// {
//     Console.WriteLine("Чисел должно быть не более 8!");
//     Console.Write("Введите количество чисел: ");
//     n = int.Parse(Console.ReadLine()!);
// }

// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// int resultNumber = 0, count = array.Length - 1;
// for (int i = 0; i < array.Length; i++){
//     resultNumber += array[i] * Convert.ToInt32(Math.Pow(10, count));
//     count--;
// }

// Console.WriteLine(resultNumber);

/*
Задача 1: 
Напишите программу, которая бесконечно запрашивает 
целые числа с консоли. Программа завершается при вводе символа 
‘q’ или при вводе числа, сумма цифр которого чётная.
*/

int sumNumber (int num){
    int summa = 0;
    if (num < 0)
        num *= -1;
    while (num != 0){
        summa += num % 10;
        num /= 10;
    }
    return summa;
}

bool continueInput(string line){
    if (line == "q")
        return false;
    else if (sumNumber(int.Parse(line)!) % 2 == 0)
        return false;
    return true;
}

Console.Clear();
Console.Write("Введите целое число\n" + 
"(для выхода введите 'q' или число, сумма цифр которого - чётная):");
string input_line = Console.ReadLine()!;

while (continueInput(input_line)){
    Console.Write("Введите целое число: ");
    input_line = Console.ReadLine()!;
}
// Console.WriteLine(input_line);
// Console.WriteLine(continueInput(input_line));