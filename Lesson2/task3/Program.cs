// int n = 10;
// int[] array = { 11, 12, 87, 14, 121, 115, 123, 17, 19, 22 };
// int i = 0;

// while(i < n)
// {
//     if(array[i] % 2 == 0)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     i = i + 1;
// }

// int n = 10;
int[] array = { 11, 12, 87, 14, 121, 115, 123, 17, 19, 22 };
int i = 0;

while(i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write(array[i]);
        Console.Write(' ');
    }
    i = i + 1;
}