// Rotate an array by one position


int[] arr = new int[] { 1, 2, 3, 4, 5 };

var last = arr[arr.Length - 1];

for (int i = arr.Length - 1; i > 0; i--)
{
    arr[i] = arr[i-1];
}

arr[0] = last;

foreach (var item in arr)
    Console.Write(item + " ");


Console.ReadLine();