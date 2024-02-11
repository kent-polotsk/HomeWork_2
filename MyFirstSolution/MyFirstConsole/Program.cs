// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

/* 1 В методе Main консольного проекта создать переменную типа int со значением 10. Вывести ее на консоль.Сделать так, чтобы программа завершала работу только тогда, когда вы введете с клавиатуры какой-либо символ и нажмете Enter. */

int firstVar = 10;
Console.WriteLine($"{nameof(firstVar)} = {firstVar}");

char ch = Console.ReadKey(true).KeyChar;
Console.WriteLine(ch);

bool test = true;
do
{
    if (Console.ReadKey(true).KeyChar == (char)ConsoleKey.Enter)
    { test = false; }
}
while (test);
return;

