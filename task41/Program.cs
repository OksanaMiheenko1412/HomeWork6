// task41 Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел
// больше 0 ввел пользователь. 0,7,8,-2,-2 ->2; -1,-7,567,89,223 ->3

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 1000);
}

int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
//  вариант решения из семинара7
//Console.Clear();
//string[] numbers = Console.ReadLine().Split(" ");
//int count = 0;
//foreach (string i in numbers)
//{
//   if (int.Parse(i) > 0)
//        count++;
//} 
//Console.WriteLine(count);

