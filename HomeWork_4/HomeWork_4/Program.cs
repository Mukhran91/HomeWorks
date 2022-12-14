
using System.Globalization;

namespace homework3;

class Program{
    
static void Main(string[] args)
{
    #region task1
    Console.WriteLine("Enter Num : ");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i < 10; i++)
    {
        Console.WriteLine($"{i} * {n} = {i * n}");
    }
    #endregion

    #region task2
    
    Console.WriteLine("Enter Num : ");
    int x = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i < x; i++)
    {
        if (i % 2 == 0 )
        {
            Console.WriteLine(i * i);
            
        }
        
    }
    #endregion

    #region task3
    
    Console.WriteLine("Enter Num");
    int z = Convert.ToInt32(Console.ReadLine());

    int[] arr = new int[z];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    List<int> even = new List<int>();
    List<int> odd = new List<int>();

    foreach (var i in arr)
    {
        if(i % 2 == 0)
            even.Add(i);
        else
        {
            odd.Add(i);
        }
    }

    foreach (var i  in even)
    {
        Console.Write(i + ", ");
    }
    Console.WriteLine();
    foreach (var i in odd)
    {
        Console.Write(i + ",  ");
        
    }
    #endregion
    
    Console.WriteLine();
    #region task4
    
    Console.WriteLine("Enter Num");
    int y = Convert.ToInt32(Console.ReadLine());

    int[] a = new int[z];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    foreach (var i in a.GroupBy(e => e))
    {
        Console.WriteLine($"{i.Key} appears {i.Count()} times sum {i.Sum()}");
    }
    #endregion

    #region task5

    int[] arry = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
    Console.WriteLine("Enter Num");
    int N = Convert.ToInt32(Console.ReadLine());
    
    foreach (var VARIABLE in arry.Reverse().Take(N).Reverse() )
    {
        Console.WriteLine(VARIABLE);
        
    }
    
    #endregion

}
}


