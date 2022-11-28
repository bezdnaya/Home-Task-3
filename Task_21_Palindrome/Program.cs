Console.WriteLine ("Введите 5-значное число");
int Number = Convert.ToInt16(Console.ReadLine());
if (Number/10000 == Number%10)
{
    if ((Number/1000)%10 == (Number/10)%10)
    Console.WriteLine ($"Число {Number} палиндром");
}
else
    Console.WriteLine ($"Число {Number} не палиндром");
