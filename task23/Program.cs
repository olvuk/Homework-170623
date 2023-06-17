int inputNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void getNumberCubed(int number)
{
    int index = 1;
    double result = 0;
    while (index <= number)
    {
        result = Math.Pow(index, 3);
        index++;
        
        if (index != number + 1)
        {
            Console.Write(result + ", ");
        }
        else
        {
            Console.Write(result + ".");
        }
    }

}

int number = inputNumber("Введите, пожалуйста, число");
getNumberCubed(number);
