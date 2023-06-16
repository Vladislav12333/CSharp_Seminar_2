//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Например: 
//78 ->8
//12 ->2
//85 ->8

Random rand = new Random();

int randomNumber = rand.Next(10, 100);
System.Console.WriteLine(randomNumber);

if (randomNumber / 10 > randomNumber % 10)
{
    System.Console.WriteLine($"Левое число больше -> {randomNumber / 10}");
}
else if (randomNumber % 10 > randomNumber / 10)
{
    System.Console.WriteLine($"Правое число больше -> {randomNumber % 10}");
}
else
{
    System.Console.WriteLine("Числа равны");
}