Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int negative_number = number * -1; // определяем границу диапозона - то же число, но со знаком минус 

while negative_number <= number // пока наше отрицательное число меньше или равно положительному 
{
    Console.Write(negative_number); // выводим это число в строку
    negative_number++; // то же самое, что negative number = negative_number + 1(??)
}