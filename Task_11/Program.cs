//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Например: 
//78 ->8
//12 ->2
//85 ->8

int randomNumber = new Random().Next(10, 100); // [10, 100) [-обозначает что входит в деапазон, )-обозначает что не входит в деапазон.
System.Console.WriteLine(randomNumber);

int leftNumber = randomNumber / 10;
int rightNumber = randomNumber % 10;

if (leftNumber > rightNumber)
{
    System.Console.WriteLine($"Левое число больше -> {leftNumber}");
}
else if (rightNumber > leftNumber)
{
    System.Console.WriteLine($"Правое число больше -> {rightNumber}");
}
else
{
    System.Console.WriteLine("Числа равны");
}