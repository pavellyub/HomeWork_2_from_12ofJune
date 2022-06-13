// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Ошибка. Такого дня недели не существует");
}
else
{
    if (day >= 1 && day <= 5)
        {
            Console.WriteLine("Это рабочий день");
        }
    else
        {
            Console.WriteLine("Это выходной день");
        }
}

