/* Zadacha 34 
int ChetnieChisla(int N)
{
    int k = 0;
    int[] array = new int[N];
    Random rand = new Random();
    Console.WriteLine("Массив чисел: ");
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = rand.Next(999);
        Console.Write(" " + array[i]);
    }    
for (int i = 0; i<array.Length; i++)
   {
      if (array[i] % 2 == 0)
      {
        k++;
      }
   }
   return k;
}
Console.Write("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
int result = ChetnieChisla(a);
Console.WriteLine("");
Console.WriteLine("Количество четных чисел в массиве = " + result);
*/
/* Zadacha 36 
int SumNechetIndex(int N)
{
    int[] array = new int[N];
    Random rand = new Random();
    int sum = 0;
    Console.WriteLine("Массив чисел: ");
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = rand.Next(10000);
        Console.Write(" " + array[i]);
    }  
    for (int i = 0; i<array.Length; i++)
    {
        if (i % 2 != 0)
        sum = sum + array[i];
    }
 return sum;
}
Console.Write("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SumNechetIndex(a);
Console.WriteLine("");
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях  = " + result);
*/
/* Zadacha 38 
float Raznicha(int N)
{
   float[] array;
   array = new float[N];
    Random rand = new Random();
    float razn = 0;
    Console.WriteLine("Массив чисел: ");
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = rand.Next(1,10000);
        Console.Write(" " + array[i]); 
    }   
    float min = 100000;
    float max = 0;
     for (int i = 0; i<array.Length; i++)
     {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        
        razn = max - min;
     }
     return razn;
}
Console.Write("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
double result = Raznicha(a);
Console.WriteLine("");
Console.WriteLine("Разница между максимумом и минимумом  = " + result);
*/