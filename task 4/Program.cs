Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

int number2 = number % 10; // остаток от деления. если делить трехзначное число на 10, то после запятой как раз получится последняя цифра
Console.WriteLine(number2);
