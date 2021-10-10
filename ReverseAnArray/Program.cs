// Reverse an array

int[] arr = new int[] { 1, 2, 3 };

List<int> result = new List<int>();

for(int i = arr.Length - 1; i >= 0; i--)
{
    result.Add(arr[i]);
}

foreach(var item in result)
    Console.Write(item + " ");

Console.ReadLine();


// Result = [3,2,1]
// Time Complexity = O(n)