// int[] arrayInt = new int[5]; // [0, 0, 0, 0, 0]
// string[] arrayString = new string[5]; // ["", "", "", "", ""]
// char[] arrayChar = new char[5]; // ['', '', '', '', '']

//----------------
/*
Задание 1.

Задайте массив символов (тип char []). Создайте строку из
символов этого массива.

Конструктор строки вида string(char []) не использовать.
char[] chars = new char[] { 'a', 'b', 'c', 'd' };
string str = new string(chars) -> в данном случае не использовать

Пример
['a', 'b', 'c', 'd'] => "abcd"
*/

// Console.Clear();
// Console.Write("Кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// char[] chars = new char[n];
// for (int i = 0; i < chars.Length; i++){
//     Console.Write("Введите элемент массива: ");
//     chars[i] = char.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");
// Console.WriteLine(string.Join("", chars)); // простой вариант в одну строку
// // то же самое с помощью цикла
// string result = "";
// foreach (char element in chars){
//     result += element;
// }
// Console.WriteLine(result);

//----------------
/*
Задание 2.

На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.

Метод строки ToCharArray() не использовать.
string str = "Hello!"
char[] characters = str.ToCharArray(); -> в данном случае не использовать

Пример
"Hello!" => ['H', 'e', 'l', 'l', 'o', '!' ]
*/

// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// char[] chars = new char[str.Length];
// for (int i = 0; i < str.Length; i++){
//     chars[i] = str[i];
// }
// Console.WriteLine($"Результат: [{string.Join(", ", chars)}]");

//----------------
/*
Задание 3.

Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных.

Пример
"hello" => 2
"world" => 1
*/

// bool checkVowel(char ch, char[] vowels){
//     foreach (char element in vowels){
//         if (ch == element)
//          return true;
//     }
//     return false;
// }

// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
// int count = 0;
// for (int i = 0; i < str.Length; i++){
//     if (checkVowel(str[i], vowels))
//         count++;
// }
// Console.WriteLine(count);

// ======================================

Console.Clear();
Console.WriteLine(@"Задача 1:
Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.
");


