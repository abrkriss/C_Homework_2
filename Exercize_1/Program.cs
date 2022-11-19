void Exercize1()
{
    //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.WriteLine("Введите трехначное число ");
    int number = Convert.ToInt32(Console.ReadLine());
    if ((99 < number) &  (number < 1000))
    {
    int tens = number / 100;
    int ones = number % 10;
    int result = (number - ((tens * 100) + ones)) / 10;
    Console.WriteLine("Это же число без первой и третьей цифер " + result);
    }
    else
    {
        Console.WriteLine("Введено некорректное число");
    }
}
Exercize1();
