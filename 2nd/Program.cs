Random rnd = new Random();
int number = rnd.Next(1, 10000000);

int digitCount = (int)Math.Log10(number) + 1;

Console.WriteLine(number);

if(digitCount >=3)
{

while ( digitCount > 3 )
{
   number = number / 10;
   digitCount = digitCount - 1;
}

 int result = number % 10;
 Console.WriteLine($"Третья цифра {result}");
}

else{

  Console.WriteLine("Третьей цифры нет");
}



