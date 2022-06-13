// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = Input ("Введите ваше число: ");
int secondDigit = 0;

if (number < 99)
{
    Console.WriteLine("Ошибка. В числе нет третьей цифры");
}
else
{
    while (number > 999)   
        {
            number = number / 10;
        }
    secondDigit = number % 10;
    Console.WriteLine($"Третья цифра заданного числа: {secondDigit}");    
}

int Input (string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}