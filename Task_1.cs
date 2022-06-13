// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = Input("Введите трехзначное число: ");

if (number < 1000 && number > 99)
{
    int firstDidgit = number % 100;
    int secondDidgit = firstDidgit / 10;
    Console.WriteLine($"Вторая цифра вашего числа: {secondDidgit}");
}
else
{
    Console.WriteLine("Ошибка. Вы ввели не трехзначное число");
}

int Input (string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}