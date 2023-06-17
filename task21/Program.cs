int inputNumber(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double findDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}

int x1 = inputNumber("Введите, пожалуйста, координату х точки А");
int y1 = inputNumber("Введите, пожалуйста, координату y точки А");
int z1 = inputNumber("Введите, пожалуйста, координату z точки А");
int x2 = inputNumber("Введите, пожалуйста, координату х точки B");
int y2 = inputNumber("Введите, пожалуйста, координату y точки B");
int z2 = inputNumber("Введите, пожалуйста, координату z точки B");

double distanceAB = findDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(distanceAB);