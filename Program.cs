string[] strArray = new string[5] {"Hi", "Git", "hello", "world", "Hub"};
string[] strArrayNew = new string[strArray.Length];

void SecondArray(string[] strArray, string[] strArrayNew)
{
    int count = 0;
    for (int i = 0; i < strArray.Length; i++)
    {
    if(strArray[i].Length <= 3)
        {
        strArrayNew[count] = strArray[i];
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

SecondArray(strArray, strArrayNew);
PrintArray(strArrayNew);