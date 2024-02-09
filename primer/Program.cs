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
int maxDouble(int x, int y){
    if (x > y)
        return x;
    return y;
}
// return - возвращает значение откуда была вызвана функция!!!
// return - моментально завершает работу функции!!!
int result = maxDouble(12, 18);
Console.WriteLine(result);
Console.WriteLine(maxDouble(-1, 5));
Console.WriteLine(maxDouble(134, 8));
Console.WriteLine(maxDouble(-89, 56));