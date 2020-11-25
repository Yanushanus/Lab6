using System;
using System.Linq;
namespace Lab6
{
    class Array
    {
        public static int[] Dimension()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your row ");
                    
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your column ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int[] IntArr = new int[] { a, b };
                    return IntArr;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong dimension\n");
                    continue;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Wrong dimension\n");
                    continue;
                }
            }

        }
        public static int[,] RandomInt(int[] IntArr)
        {
            int a = IntArr[0];
            int b = IntArr[1];
            int[,] RandomArray = new int[a, b];
            Random rand = new Random();
            for (int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    RandomArray[i, j] = rand.Next(1, 41);
                }
            }
            return RandomArray;
        }
        public static void Output(int[,] RandomArray)
        {
            int a = RandomArray.GetLength(0);
            int b = RandomArray.GetLength(1);
            
            for (int i = 0; i < a; i++)
            {
                
                for (int j = 0; j < b; j++)
                {
                    Console.Write(RandomArray[i, j]);
                    if (j < b - 1) { Console.Write(", "); }

                }
               
                if (i < a - 1) { Console.Write(",\n"); }
            }
            
            return;
        }
        public static int Search()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nEnter your key,which position you want to find ");                   
                    int key = Convert.ToInt32(Console.ReadLine());
                    if(key>=1 && key <= 40)
                    {
                        return key;
                    }
                    else
                    {
                        Console.WriteLine("Your noun out of range");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unknown format\n");
                    continue;
                }
            }

        }
        public static void SearchForKey(int[,] Dimension, int key)
        {
            int a = Dimension.GetLength(0);
            int b = Dimension.GetLength(1);
            bool tr = true;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (Dimension[i, j] == key)
                    {
                        Console.WriteLine($"Key on position: [{i},{j}]");
                        tr = false;
                    }

                }

            }

            if (tr)
            {
                Console.WriteLine("Key wasn't found");
            }
        }
        public static void Arifm(int[,] DimensionalArray)
        {
            int a = DimensionalArray.GetLength(0);
            int b = DimensionalArray.GetLength(1);
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum = 0;
                for (int j = 0; j < b; j++)
                {
                    sum += DimensionalArray[i, j];
                }
                sum = sum / a;
                Console.WriteLine($"Your sum in {i+1} row={sum}");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] DimensionArr = Array.Dimension();
            int[,] RandomArr = Array.RandomInt(DimensionArr);
            Array.Output(RandomArr);
            int key = Array.Search();
            Array.SearchForKey(RandomArr, key);
            Array.Arifm(RandomArr);

        }
    }
}
