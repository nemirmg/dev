﻿// Функции и процедуры (методы???)

// методы - это понятие допустимо только в ООП

// Простая процедура

// void f() {
//         Console.WriteLine("Hello, world!");
//     }
    
// Console.Clear();
// f();
// f();
// f();

// Процедура принимает аргументы

// передача по значению
void f(int n){
    n = n + 5;
}

int n = 10;
f(n);
Console.WriteLine(n);