/*
Сортировка подсчётом (теория)
=============================

[0, 2, 3, 2, 1, 5, 9, 1, 1] - исходный массив из цифр (0...9)

создаём вспомогательный массив из 10 элементов
(для хранения количества цифр исходного массива)
[0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

у каждого элемента вспомогательного массива есть индекс:
0, 1, 2, 3, 4, 5, 6, 7, 8, 9

подсчитываем количество каждой цифры из исходного массива 
и заносим его во вспомогательный массив:
[1, 3, 2, 1, 0, 1, 0, 0, 0, 1]
 0  1  2  3  4  5  6  7  8  9

 отсортированный массив формируется из вспомогательного:
 выводим последовательно индексы вспомогательного массива то количество раз, 
 сколько эта цифра встречалась в исходном массиве
 [0, 1, 1, 1, 2, 2, 3, 5, 9]
*/

//------------------------------
// сортировка цифр (0...9)
/*
void CountingSort(int[] inputArray)
{
    int n = 10;
    int[] counters = new int[n];
    int ourNumber;
    
    for (int i = 0; i < inputArray.Length; i++)
    {
        // counters[inputArray[i]]++;
        ourNumber = inputArray[i];
        counters[ourNumber] += 1;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}

// int[] array = {0, 2, 3, 2, 1, 5, 9, 1, 1};
// int[] array = {0, 2, 3, 2, 1, 5, 9, 1, 1, 2, 1, 3, 4, 6, 3, 1, 4, 8, 5, 2};
int[] array = {3, 2, 1, 5, 9};
CountingSort(array);
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", array)}]");
*/
//------------------------------
// сортировка натуральных чисел (0 ... неизвестно)
/*
int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int[] counters = new int [max + 1];
    int[] sortedArray = new int[inputArray.Length];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i;
            index++;
        }
    }

    return sortedArray;
}

int[] array = {0, 2, 4, 10, 20, 5, 6, 1, 2};
int[] sortedArray = CountingSortExtended(array);
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", sortedArray)}]");
*/
//------------------------------
// сортировка целых чисел (-оо ... +оо)

int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();
    // универсальное смещение для индексов вспомогательного массива
    int offset = -min;
    
    int[] counters = new int [max + offset + 1];
    int[] sortedArray = new int[inputArray.Length];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i - offset;
            index++;
        }
    }

    return sortedArray;
}

int[] array = {-10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1};
int[] sortedArray = CountingSortExtended(array);
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", sortedArray)}]");