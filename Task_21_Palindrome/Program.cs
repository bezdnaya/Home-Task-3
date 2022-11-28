Console.WriteLine ("Введите 5-значное число");
int Number = Convert.ToInt16(Console.ReadLine());
int [] array = new int[5];
int index = 4;
while (index >= 0)
{
    array[index] = Number%10;
    Number = Number/10;
    index = index - 1;
}
if (array[0] == array[4])
{
    if (array[1] == array[3])
    Console.WriteLine ($"Введённое вами число палиндром");
}
else
    Console.WriteLine ($"Введённое вами число не палиндром");

