// Задачка под нахождение квадрата числа

int a, b;

string UserEnter;

Console.Write("Введите число ");
UserEnter = Console.ReadLine()!;

a = int.Parse(UserEnter);
b = a * a;

Console.Write($"Квадрат введенного числа = {b}");
