Console.WriteLine("Введите цифру от 1 до 7");
int userNumber = Convert.ToInt32(Console.ReadLine());
if ( userNumber < 1 || userNumber > 7)
{
    Console.WriteLine ("В неделе 7 дней, перезапустите программу и введите цифру от 1 до 7");
}
else
{
    if (userNumber == 6 || userNumber == 7)
    {
         Console.WriteLine ($"{userNumber} -> да");
    }
    else
    {
        Console.WriteLine ($"{userNumber} -> нет");
    }
}