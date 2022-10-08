int getSecondDigitNumber (int userNumber)
{
    int secondDigit = userNumber % 100 / 10;
    if (secondDigit < 0) secondDigit = secondDigit * -1;
    return secondDigit;
}

Console.WriteLine("Введите трехзначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
if ((userNumber>99 && userNumber<1000)||(userNumber>-1000 && userNumber<-99))
{
    int secondDigit = getSecondDigitNumber (userNumber);
    Console.WriteLine ($"{userNumber} -> {secondDigit}");
}
else
{
    Console.WriteLine ("Вы ввели не трехзначное число. Запустите программу заново и введите трехзначное число");
}