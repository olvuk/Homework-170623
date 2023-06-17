int inputNumber(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void checkNumber(int number)
{
    if (number > 9999 && number < 100000)
    {
        int num5 = number % 10;
        int num4 = (number / 10) % 10;
        int num3 = (number / 100) % 10;
        int num2 = (number / 1000) % 10;
        int num1 = (number / 10000) % 10;

        if (num1 == num5 && num2 == num4)
        {
            Console.WriteLine(number + " является палиндромом");
        }
        else
        {
            Console.WriteLine(number + " не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число");
    }

}

int number = inputNumber("Введите, пожалуйста, пятизначное число");
checkNumber(number);

