// Поиск максимального из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//             0  1  2  3  4  5  6  7  8
int[] array = {12,23,34,45,52,61,37,84,39};
//array[0] = 12; // обращение к массиву и записать значение по индексу
//Console.WriteLine(array[0]); // обращение к массиву и прочитать значение по индексу

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);