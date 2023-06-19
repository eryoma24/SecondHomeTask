int Prompt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число => ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста повторите ввод");
    return;
}
System.Console.WriteLine($"Введенное число '{number}'");
int secondRank = number / 10 % 10;
System.Console.WriteLine($"Вторая цифра '{secondRank}'");