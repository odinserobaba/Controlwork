Console.WriteLine("Введите элементы массива через пробел:");
string[] inputArray = Console.ReadLine().Split(' ');
Console.WriteLine("Введенный массив:");
foreach (string item in inputArray)
{
    Console.WriteLine(item);
}
Console.WriteLine("Результат:");

string[] resultArray = FilterStrings(inputArray);

foreach (string item in resultArray)
{
    Console.WriteLine(item);
}




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