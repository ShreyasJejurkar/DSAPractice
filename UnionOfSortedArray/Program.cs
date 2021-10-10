// Problem - Union of sorted array. 

/*Approch 
 * 1. Add ARR1 elements to result directly. 
 * 2. for loop over arr2 elements and check element do exists in result. 
 * 3. If not then add it and else ignore it.
 * 
 * Approch
 * 1. Add both array to result list with AddRange method. 
 * 2. Then convert list to HashSet<int>
 * 3. Hashset will remove duplicate elements automatically. 
 * 4. Print the hashset.
 *  List<int> result = new List<int>();
    result.AddRange(arr1);
    result.AddRange(arr2);

    HashSet<int> set = new HashSet<int>(result);
 */

int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[] { 1, 2, 3, 8, 9 };

List<int> result = new List<int>();

result.AddRange(arr1);

foreach(var item in arr2)
{
    if(!arr1.Contains(item))
    {
        result.Add(item);
    }
}

foreach(var item in result)
    Console.Write(item + " ");


Console.ReadLine();