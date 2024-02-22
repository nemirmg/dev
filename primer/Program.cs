/*
Распараллеленая сортировка подсчётом
====================================

исходный массив:
[0, 1, 2, 5, 1, 1, 3, 6]

Threads = 2

создаём вспомогательный массив:
counters = [0, 0, 0, 0, 0, 0, 0]
            0  1  2  3  4  5  6

заполняем вспомогательный массив последовательно:
counters = [1, 3, 1, 1, 0, 1, 1]
(serial)    0  1  2  3  4  5  6

для параллельного заполнения вспомогательного массива 
разделим исходный на 2 части:

  thread_1  |  tread_2 
[0, 1, 2, 5,| 1, 1, 3, 6]

counters = [0, 0, 0, 0, 0, 0, 0]
(parallel)  0  1  2  3  4  5  6

Каждый поток начинает практически одновременно 
заполнять вспомогательный массив.
При этом может возникнуть коллизия, когда оба потока 
начнут изменять один и тот же элемент массива (гонка потоков).
В этом случае нужно установить очерёдность записи.
Например, можно "заморозить" выполнение всех потоков, 
пока текущий не завершит своё действие 
относительно данного элемента массива.
*/

//------------------------------
// сортировка целых чисел (-оо ... +оо)

const int THREADS_NUMBER = 4; // число потоков
const int N = 100_000; // размер массива

void PrepareParallelCountingSort(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];

    int eachThreadCalc = N / THREADS_NUMBER;
    var threadsParall = new List<Thread>();

    int startPos = 0, endPos = 0;
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        startPos = i * eachThreadCalc;
        if (i == THREADS_NUMBER - 1)
        {
            endPos = N;
        }
        endPos = (i + 1) * eachThreadCalc;

        threadsParall.Add(new Thread(() => CountingSortParallel(inputArray, counters, 
                                                                offset, startPos, endPos)));
        threadsParall[i].Start();
    }
    
    foreach (var thread in threadsParall)
    {
        thread.Join();
    }
}

void CountingSortParallel(int[] inputArray, int[] counters, 
                          int offset, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        counters[inputArray[i] + offset]++;
    }
}

void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();
    // универсальное смещение для индексов вспомогательного массива
    int offset = -min;
    
    int[] counters = new int [max + offset + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }

}

bool EqualityMatrix(int[] fmatrix, int[] smatrix)
{
    bool res = true;

    for (int i = 0; i < N; i++)
    {
        res = res && (fmatrix[i] == smatrix[i]);
    }
    
    return res;
}

// int[] array = {-10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1};
// int[] sortedArray = CountingSortExtended(array);

Random rand = new Random();
int[] resSerial = new int[N].Select(r => rand.Next(0, 5)).ToArray();
int[] resParallel = new int[N];

CountingSortExtended(resSerial);
PrepareParallelCountingSort(resParallel);
Console.WriteLine(EqualityMatrix(resSerial, resParallel));

Array.Copy(resSerial, resParallel, N);