
int[] CreateArray(int count)
{
    return new int[count];
}
void FillArray(int[] arrayA, int minValue, int maxValue) 
{
    int count = arrayA.Length;
    for (int i = 0; i < count; i++)
    {
        arrayA[i] = new Random().Next(minValue, maxValue);
    }
}
string PrintArray(int[] array) 
{
    int count = array.Length;
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

int[] EvenNumbers(int[] array)
{
    int[] arrayB = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            arrayB[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref arrayB, count);
    return arrayB;
}

int[] array = CreateArray(15); 
FillArray(array,0,100); 
Console.WriteLine(PrintArray(array)); 
Console.WriteLine(PrintArray(EvenNumbers(array))); 