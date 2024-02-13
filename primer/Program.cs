// Быстрая сортировка O(log2(n) * n)

// Напишите программу, которая сложит 2 числа a и b без прямого сложения.
// Рекурсия

int sumNumbers(int n, int m){
    if (m == 0)
        return n;
    return sumNumbers(n + 1, m - 1);
}
/*
f = sumNumbers

f(5, 3) -> f(6, 2) -> f(7, 1) -> f(8, 0) -> 8
*/
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{a} + {b} = {sumNumbers(a, b)}");