# Controlwork
***Задача: Написать программу, которая из имеющегося массива
строк формирует новый массив из строк, длина которых меньше,
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.***


**Примеры:**
1. [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
2. [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
3. [“Russia”, “Denmark”, “Kazan”] → []

Функция `FilterStrings ` фильтрует входящий массив ```inputArray``` и возвращает отфильтрованную массив, где каждый
элемент <=3.

```
string[] FilterStrings(string[] inputArray)
{
    int count = 0;

    // Подсчет количества строк, удовлетворяющих условию
    foreach (string item in inputArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }

    // Создание нового массива
    string[] resultArray = new string[count];
    int index = 0;

    // Заполнение нового массива строками, удовлетворяющими условию
    foreach (string item in inputArray)
    {
        if (item.Length <= 3)
        {
            resultArray[index] = item;
            index++;
        }
    }

    return resultArray;
}