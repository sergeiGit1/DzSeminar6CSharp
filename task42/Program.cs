// Задача 42 (необязательно): Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");//Для отрицательных не делал т.к. доп задача :)
int binary = Convert.ToInt32(Console.ReadLine());
int[] arrayBinary = new int[GetSize(binary)];

for (int i = 0; binary >= 1; i++)
{
    int temp = 0;
    temp = binary % 2;
    binary /= 2;
    arrayBinary[i] = temp;
}

int GetSize(int binaryLocal)
{
    int count = 0;
    for (int i = 0; binaryLocal >= 1; i++)
    {
        binaryLocal /= 2;
        count++;
    }
    return count;
}

void ReverseArray(int[] arrayBinary)
{
    int j = arrayBinary.Length - 1;
    for (int i = 0; i < arrayBinary.Length / 2; i++, j--)
    {
        int tempLocal = arrayBinary[i];
        arrayBinary[i] = arrayBinary[j];
        arrayBinary[j] = tempLocal;
    }
}
ReverseArray(arrayBinary);
Console.WriteLine($"Двоичное: {String.Join("", arrayBinary)}");



