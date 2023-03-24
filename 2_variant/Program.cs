// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

// Пример без встроенных функций и с вводом от пользователя
// string[] elArray = { "hello", "2", "world", ":-)" }; // => ["2", ":-)"]
// string[] elArray = { "1234", "1567", "-2", "computer science" }; // => ["-2"]
// string[] elArray = { "Russia", "Denmark", "Kazan" }; // => []

Console.Clear();
Console.Write("Введите значения масива через запятую с пробелом: ");
string[] elArray = Console.ReadLine()!.Split(", ");


int length = elArray.Length;
// Console.WriteLine(length);
int count = 0;
for (int i = 0; i < length; i++)
{
    if (elArray[i].Length <= 3)
    {
        count++;
    }
}
// Console.WriteLine(count);
Console.Write("[");
for (int i = 0; i < length; i++)
{
    if (elArray[i].Length <= 3)
    {
        if (count > 1)
        {
            count--;
            Console.Write($"\"{elArray[i]}\", ");
        }
        else Console.Write($"\"{elArray[i]}\"]");
    }
}