// Sort an array contains only 0s 1s and 2s


int[] arr = new int[] { 0, 2, 1, 2, 0 };
// { 0,0,1,2,2 }


int start = 0;
int end = arr.Length - 1;

int i = 0;

while(i <= end)
{
    if(arr[i] == 0)
    {
        arr[start] = 0;

        start++;
        i++;
    }
    else if (arr[i] == 2)
    {
        arr[end] = 2;
        arr[i] = 1;

        end--;
    }
    else
    {
        i++;
    }
}

foreach(var item in arr)
    Console.Write(item + " ");

Console.ReadLine();
