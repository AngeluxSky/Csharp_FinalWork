string[] array = new string[4] {"1234", "1567", "-2", "computer science"};
// string[] array = new string[4] {"Hello", "2", "world", ":-)"};
// string[] array = new string[3] {"Russia", "Denmark", "Kazan"};
string[] stringArray = new string[array.Length];
void SecondStringArray(string[] array, string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        stringArray[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondStringArray(array, stringArray);
PrintArray(stringArray);