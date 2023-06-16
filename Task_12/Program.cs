//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 % num1 == 0)
{
    Console.WriteLine(num2 + " кратно " + num1);
}
else
{
    int remainder = num2 % num1;
    Console.WriteLine(num2 + " не кратно " + num1 + ". Остаток от деления: " + remainder);
}

Console.ReadKey();