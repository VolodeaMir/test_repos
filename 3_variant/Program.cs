// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

// Пример без вводаот от пользователя
// для этого необходимо раскоментировать одну из строк - либо 11, либо 12, либо 13 строку (только одну из них).

Console.Clear();

string[] elArray = { "hello", "2", "world", ":-)" }; // => ["2", ":-)"]
// string[] elArray = { "1234", "1567", "-2", "computer science" }; // => ["-2"]
// string[] elArray = { "Russia", "Denmark", "Kazan" }; // => []

string[] strArray = Array.FindAll(elArray, el => el.Length <= 3);
int count = strArray.Length;

Console.Write("[");
if (count > 0)
{
    foreach (var el in strArray)
    {
        if (count > 1)
        {
            count--;
            Console.Write($"\"{el}\", ");
        }
        else Console.Write("\"" + el + "\"]");
    }
}
else Console.Write("]");