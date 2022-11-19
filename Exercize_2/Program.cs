void Exercize2()
{
    Console.WriteLine("Введите трехзначное число: ");
    int n = Convert.ToInt32(Console.ReadLine());

     if ((99 < n) &  (n < 1000))
    {
    int ones = n % 10;
    Console.WriteLine("Третья цифра заданного числа " + ones);
    }
    else
    {
        Console.WriteLine("Введено некорректное число");
    }
}
Exercize2();

