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

Console.Clear();
Console.Write("Кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
char[] chars = new char[n];
for (int i = 0; i < chars.Length; i++){
    Console.Write("Введите элемент массива: ");
    chars[i] = char.Parse(Console.ReadLine()!);
}
Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");
Console.WriteLine(string.Join("", chars)); // простой вариант в одну строку
// то же самое с помощью цикла
string result = "";
foreach (char element in chars){
    result += element;
}
Console.WriteLine(result);