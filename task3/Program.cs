// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Вычисление кубов значений чисел от 1 до N");
Console.WriteLine("Введите число N: ");
if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0) {
Console.WriteLine("Введено не целое или отрицательное число");
return;
}

void func(int N) {
    int count = 1;
    Console.Write((int) Math.Pow(count, 3));
    count++;
    while(count <= N) {
        Console.Write(", " + (int) Math.Pow(count, 3));
        count++;
    }
}

func(N);