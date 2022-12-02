Random rnd = new Random();

int number = rnd.Next(100, 1000);

Console.WriteLine(number);

int result = number % 100;
result = result / 10;

Console.WriteLine(result);
