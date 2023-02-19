// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int QuantityOrFigure(string message)
{
    System.Console.WriteLine(message);
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    return arrayLength;
}

int[] FillArray(int howLong)
{
    int[] arr = new int[howLong];
    for (int i = 0; i < howLong; i++)
    {
        arr[i] = QuantityOrFigure($"Введите {i+1}-е целое число"); // лучше так или как было 
        //в первом варианте моего решения?
    }
    return arr;
}
int Positive(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        System.Console.Write($"{massive[i]}");
        if (i < massive.Length - 1)
        {
            System.Console.Write($", ");
        }
    }
}
int arrayLength = QuantityOrFigure("Сколько числе Вы хотели бы ввести?");
int[] ourMassive = FillArray(arrayLength);
int result = Positive(ourMassive);
System.Console.Write("Вы ввели числа: ");
PrintArray(ourMassive);
System.Console.WriteLine();
System.Console.WriteLine($"{result} из них больше 0");

