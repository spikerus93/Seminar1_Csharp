Console.WriteLine("Введите номер дня недели:"); string number = Console.ReadLine();int numberInt = Convert.ToInt32(number);if (numberInt == 1){ Console.WriteLine("Понедельник");}if (numberInt == 2){ Console.WriteLine("Вторник");}if (numberInt == 3){ Console.WriteLine("Среда");}if (numberInt == 4){ Console.WriteLine("Четверг");}if (numberInt == 5){ Console.WriteLine("Пятница");}if (numberInt == 6){ Console.WriteLine("Суббота");}if (numberInt == 7){ Console.WriteLine("Воскресенье");}if (numberInt >= 8 || numberInt < 1){ Console.WriteLine("Ошибка");}

Console.Write("Введите день недели: ");
string? Days = Console.ReadLine();
int IntDays = Convert.ToInt32(Days);

if (IntDays == 1)
{
    Console.WriteLine("Это понедельник");
}
if (IntDays == 2)
{
    Console.WriteLine("Это вторник");
}
if (IntDays == 3)
{
    Console.WriteLine("Это среда");
}
if (IntDays == 4)
{
    Console.WriteLine("Это четверг");
}        
if (IntDays == 5)
{
    Console.WriteLine("Это пятница");
}
if (IntDays == 6)
{
    Console.WriteLine("Это суббота");
}
if (IntDays == 7)
{
    Console.WriteLine("Это Воскресенье");
}
if (IntDays > 7)
{
    Console.WriteLine("Нет такого дня, ты не с этой планеты, парень!");
}