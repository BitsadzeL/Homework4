using System.Runtime.ConstrainedExecution;

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            //#1
            //int[] arr = new int[10];
            //int evenSum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 101);
            //}

            //for (int i = 0; i < arr.Length; i++) {
            //    if (arr[i]%2 == 0)
            //    {
            //        evenSum += arr[i];
            //    }            
            //}

            //Console.WriteLine(evenSum);




            //#2
            //int[] src = new int[10];
            //int[] dest= new int[10];

            //for (int i = 0; i < src.Length; i++)
            //{
            //    src[i] = random.Next(0, 10);
            //}

            //for (int i = 0; i < src.Length; i++)
            //{
            //    dest[i] = src[i];
            //}

            //for (int i = 0; i < src.Length; i++)
            //{
            //    Console.WriteLine(src[i]);
            //}        
            //for (int i = 0; i < src.Length; i++)
            //{
            //    Console.WriteLine(dest[i]);
            //}



            //#3
            //int[] arr = new int[11] { 32, 32, 35, 68, 32, 90, 9, 77, 77, 1, 1 };
            //int[] uniques = new int[11];
            //int ind = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();


            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    int min_idx = i;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[min_idx])
            //            min_idx = j;
            //    }


            //    int temp = arr[min_idx];
            //    arr[min_idx] = arr[i];
            //    arr[i] = temp;
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            //uniques[ind++] = arr[0];
            //int ctr = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    ctr = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {

            //        if (i != j && arr[i] == arr[j])
            //        {
            //            ctr++;
            //        }
            //    }

            //    if (ctr == 0)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //}







            //#4

            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 101);
            //}

            //int max = arr[0];

            //for(int i=1;i<arr.Length; i++)
            //{

            //    if(arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]+" ");
            //}

            //Console.WriteLine();

            //Console.WriteLine(max);






            //#5
            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 101);
            //}

            //int maxIndex = 0;
            //int max = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{

            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        maxIndex=i;
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine(maxIndex);






            //#6
            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 101);
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();


            //for (int i = 0; i < arr.Length - 1; i++)
            //{

            //    int min_idx = i;
            //    for (int j = i + 1; j < arr.Length; j++)
            //        if (arr[j] < arr[min_idx])
            //            min_idx = j;



            //    int temp = arr[min_idx];
            //    arr[min_idx] = arr[i];
            //    arr[i] = temp;
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();




        }
    }
}

