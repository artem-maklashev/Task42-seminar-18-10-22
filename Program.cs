/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;

}

/* int[] DoubleSystem(int number)
{
    List<int> array = new List<int>();
    while (number >= 1)
    {

        array.Add(number % 2);
        number = number / 2;

    }
    return array.ToArray();
} */

string DoubleSystem(int number)
{
    List<string> array = new List<string>();
    while (number >= 1)
    {

        array.Insert(0, (number % 2).ToString());
        number = number / 2;

    }
    return string.Join("", array.ToArray());
}


/* void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
       Console.Write(arr[i]);
   }
} */

int number = GetNumber("Введите число ");


Console.WriteLine(DoubleSystem(number));
//PrintArray(array);




