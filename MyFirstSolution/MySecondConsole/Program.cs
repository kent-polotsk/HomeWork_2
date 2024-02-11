// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.OutputEncoding = System.Text.Encoding.UTF8;


/* 2. Создайте новый проект ConsoleApp с названием MySecondConsole в MyFirstSolution .  
Дано значение числа pi, которое равно 3,141592653 и значение константа Пифагора е, которое  равно 1,414213562373095048. Нужно создать переменные e и pi присвоить им данные значения и вывести на консоль без потери точности. */

const decimal pi = 3.141592653M, e = 1.414213562373095048M ;
Console.WriteLine($"Значение числа Пи : {pi}\nЗначение константы Пифагора e : {e}");
char ch = Console.ReadKey(true).KeyChar;

/* с урока
Console.WriteLine(default(byte));
Console.WriteLine(default(sbyte));
Console.WriteLine(default(ushort));
Console.WriteLine(default(short));
Console.WriteLine(default(uint));
Console.WriteLine(default(int));
Console.WriteLine(default(ulong));
Console.WriteLine(default(long));
Console.WriteLine(default(float));
Console.WriteLine(default(double));
Console.WriteLine(default(decimal));
Console.WriteLine(default(char));
Console.WriteLine(default(string));
Console.WriteLine(default(bool));
Console.ReadKey();
*/


/* 3.Создать переменную ‘a’ типа int со значением 3. Создать переменную ‘b’ типа byte и присвоить ей значение переменной ‘a’. */

int a = 3;
byte b = (byte)a;
Console.WriteLine($"\nЗначение переменной {nameof(b)} = {b},\nТип переменной - {typeof(byte)}");



/* 4. Ввести с консоли 3 числа и найти их среднее арифметическое. 

Используйте класс Convert, либо Parse методы числовых типов данных, пример  

*Доп задание для тех кто уже ушел дальше, придумать валидацию данных, в случае если пользователь вводит некорректные данные(не числа), показывать сообщение об ошибке и попросить ввести данные повторно.
Можно использовать методы TryParse, так же советую разобраться с разницей между Parse, и методами класса Convert
See: https://metanit.com/sharp/tutorial/20.4.php
 */

double [] num = new double[3];
string? input;
Console.Write($"\nВведите поочередно 3 числа (для дробных чисел использовать разделитель ','): ");
for (int i = 0; i < 3; i++) 
{
RepeatInput:
    input = Console.ReadLine();
    if (!double.TryParse(input, out var number))
    {
        Console.Write($"Некорректное значение {i + 1}го числа. Повторите ввод: ");
        goto RepeatInput;
    }
    else
    {
        //num[i] = Convert.ToDouble(input);
        num[i] = number;
        Console.Write($"{i + 1}е число введено. ");
        if ( i < 2) Console.Write($"Введите {i + 2}е число: ");
    }
}
double result = 0;
for (int i = 0; i < 3; i++)
    result += num[i];

Console.WriteLine($"\nСреднее арифметическое трех чисел = {result / 3}");
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Работа программы завершена. Нажмите любую кнопку.");
Console.ResetColor();
Console.ReadKey();