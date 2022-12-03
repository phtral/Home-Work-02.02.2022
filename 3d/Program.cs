Random rnd = new Random();
int number = rnd.Next(1, 8);

Console.WriteLine(number);

if (number == 6 || number == 7 )
{
Console.WriteLine("Да");
}
else{
Console.WriteLine("Нет");
}



 