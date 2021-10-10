// Find kth Minimum element from array.


int[] arr = new int[] { 7, 10, 4, 3, 20, 15 };

int k = 3;

int MIN = arr[0];

int count = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] < MIN)
    {
        MIN = arr[i];
        count = count + 1;

        if(count == k)
        {
            break;
        }
    }
}

Console.WriteLine("Kth minmum element - " + MIN);

Console.ReadLine();
