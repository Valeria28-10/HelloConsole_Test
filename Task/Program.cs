string[] firstArray = new string[] {"Russia", "Denmark", "Kazan", "1234", "-2"};
string[] secondArray = new string[firstArray.Length];

void SelectionArraySort(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
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
SelectionArraySort(firstArray, secondArray);
Console.Write($"[{String.Join(", " , firstArray)}] -> ");
PrintArray(secondArray);

