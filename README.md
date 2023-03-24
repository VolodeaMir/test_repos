## **Итоговая проверочная работа.**

> <image src="images/Контрольная_работа.png" alt="Контрольная работа" border="7px solid red" />

## Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения  на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

## Задача алгоритмически не самая сложная, однако для полненного выполнения проверочной работы необходимо:

## 1. Создать репозиторий на GitHub 
## 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы  выделяете ее в отдельный метод)
<image src="images/Блок-Схема контрольной работы.png" alt="Контрольная работа" border="7px solid red" />
## 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md) 
## 4. Написать программу, решающую поставленную задачу 
## 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах) 

## **Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## **Примеры:**

## ["hello", "2", " w o r l d " , -> ["2", ":-)"]

## ["1234", "1567", "-2", "computer science"] -> ["-2"] 

## ["Russia", "Denmark", "Kazan"] -> []
# ***


# **Описание работы программы.**

## Создаём массив с типом string который заполняется пользователем через консоль. Пишем значения массива разделяя их запятой с пробелом. 
```
Console.Write("Введите значения массива через запятую с пробелом: ");

string[] elArray = Console.ReadLine()!.Split(", ");
```
## Console.ReadLine() считывает строку введённую пользователем а функция Split(", ") делит строку отдельными частями (используя разделитель - запятая с пробелом) и записывает их поочерёдно в отдельные индексы массива - elArray.

## Далее в строке

```
string[] strArray = Array.FindAll(elArray, el => el.Length <= 3); 
``` 
##  - происходит перебор значений из массива elArray по условию - что это значение должно быть меньше либо ровно 3 и те значения которые удовлетворяют условие присваивается массиву strArray а которые не прошли по условию не попадают в этот массив.

## Далее часть кода 
```
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
 ```
## выводит результат в консоль пользователю.
