//task1

/*
int n;
n = Convert.ToInt32(Console.ReadLine());

if (n <= 100)
{
    Console.Write(n + (n * 5 / 100));
}
else if (n > 100 && n <= 200)
{
    Console.Write(n + (n * 5 / 100));
}
else 

{
    Console.Write(n + (n * 10 / 100));
}
*/



//Task2

/*int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[n];
int zarb = 1;
for(int i=0; i<n; i++)
{
    arr[i] =Convert.ToInt32( Console.ReadLine());
}

for(int i=0; i<n; i++)
    {
    if (i > 0)
    {
        Console.Write("*");   
    }         
      Console.Write(arr[i]);
        zarb *= arr[i];
    }
    Console.Write(" = ");
    Console.Write(zarb); */

//Task3

/*int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int max = 0;
for (int i = 1; i < n; i++)
{

    if (arr[i] > arr[max])
    {
        max = i;
    }
}

Console.Write(max);*/


//Task 4

/* int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(arr);

for (int i = 1; i < n; i++)
{
    if(arr[i]!=arr[i - 1] && arr[i]!=arr[i + 1])
    {
        Console.Write(arr[i] + " ");
    }
}
*/
















