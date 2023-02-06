// Поищем максимум из 9 чисел

// int Max(int arg1, int arg2, int arg3)
// {
// int result = arg1;
// if (arg2 > result) result = arg2;
// if (arg3 > result) result = arg3;
// return result;
// }
//             0 1  2 3  4 5  6   7
int[] array = { 1, 0, 15, 5, 45, 951, 0, 6, 70 };
int n = array.Length;

int find = 5;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"{index}");
        break; //останавливает выполнение операции
    }
    // index = index + 1;
    index++;
}

