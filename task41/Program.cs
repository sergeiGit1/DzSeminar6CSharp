// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите сколько чисел хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа через enter: ");

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        string input = Console.ReadLine();
        int.TryParse(input, out array[i]);
        array[i] = Convert.ToInt32(input);
    }
    return array;
}

int[] resultArray= GetArray(size);
Console.WriteLine($"[{String.Join("; ",resultArray)}]");

int count=0;
for (int i = 0; i < resultArray.Length; i++)
{
    if (resultArray[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Вы ввели {count} положительных чисел");