int getThirdDigitNumber (int userNumber)
{
    int count = 0;
    if (userNumber > 0)
    {
        userNumber = userNumber;
    }
    else
    {
        userNumber = userNumber * -1;
    }
     int number = userNumber;

    while (number > 0)
    {
//        Console.WriteLine(number);
//        Console.WriteLine(count);
//        Console.WriteLine("");
        number = number / 10;
        count++;
    }
//    Console.WriteLine(userNumber);
//    Console.WriteLine(count);
    int i = 1;
    int tempNumber = userNumber;
    while (i < count - 2)
    {
//        Console.WriteLine(tempNumber);
//        Console.WriteLine(i);
//        Console.WriteLine("");
        tempNumber = tempNumber / 10;
        i++;
    }
//    Console.WriteLine(tempNumber);
    int thirdDigit = tempNumber % 10;
    return thirdDigit;
}

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber>-100 && userNumber<100)
{
    Console.WriteLine ("третьей цифры нет");
}
else
{
    int thirdDigit = getThirdDigitNumber (userNumber);
    Console.WriteLine ($"{userNumber} -> {thirdDigit}");
}