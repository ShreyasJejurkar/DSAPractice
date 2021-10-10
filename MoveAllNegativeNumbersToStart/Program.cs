
int[] arr = new int[] { -12, 11, -13, -5, 6, -7, 5, -3, -6 };

int j = 0;

var temp = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] < 0)
    {
        temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        j++;
    }
}

foreach (var item in arr)
    Console.Write(item + " ");


Console.ReadLine();