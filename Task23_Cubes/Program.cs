Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
Console.WriteLine("Кубы от 1 до N =");
while (index <= N)
{
    Console.Write($"{Math.Pow(index, 3)} ");
    index++;
}
