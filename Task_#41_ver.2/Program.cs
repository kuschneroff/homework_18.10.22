/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

bool stop = false;
int number = 0;
int sum = 0;

while(!stop) // !false = true; !true = false;
{
    Console.WriteLine("Введите число");
    number = int.Parse(Console.ReadLine() ?? "");
    if(number > 0)
    sum++;

    Console.WriteLine("Продолжить вводить числа? Y/N");
    string result = Console.ReadLine();
    if(result == "Y")
        stop = false;
    else
        stop = true;
    }
    Console.WriteLine($"Количество чисел, введенных пользователем, которые больше 0 = {sum}");