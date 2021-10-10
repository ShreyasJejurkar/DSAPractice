// Maximum and minimum of an array.

// Approch 1 - Sort an array using inbuilt function and then get first 
// and last element of it. First element will be minimum and last element
// will be maximum.
// Array.Sort(arr); Min = arr[0] Max = arr[arr.Length - 1]

/* Approch 2 - 
 * 1. Initialize max and min with some value from array first.
 * 2. IF arr[i] > MAX
 *      MAX = arr[i]
 *      
 *    IF arr[i] < MIN
 *      MIN = arr[i]
 * 3. This approch is best because it's O(n).
 */

int[] arr = new int[] { 4, 1, 23, 5, 1, 24, 511, -23 };

// Initialize variables with some value from arr itself.
// don't initialize with 0 as array might contain negative values as well.

int MIN = arr[0];
int MAX = arr[1];

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] > MAX)
    {
        MAX = arr[i];
    }

    if(arr[i] < MIN)
    {
        MIN = arr[i];
    }
}

Console.WriteLine("Max - " + MAX);
Console.WriteLine("Min - " + MIN);

Console.ReadLine();