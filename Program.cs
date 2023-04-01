string[] arr1 = new string[5] {"345", "18", "welcome", "music", "map"};
string[] arr2 = new string[arr1.Length];
void FinishArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
FinishArr(arr1, arr2);
PrintArr(arr2);