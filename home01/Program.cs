Console.WriteLine ("Введите 2 числа: ");

int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number1 > number2) max = number1;
if (number1 < number2) max = number2;

Console.Write ("max = ");
Console.WriteLine (max);
