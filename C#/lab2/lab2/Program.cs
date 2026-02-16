using System.Diagnostics;

namespace lab2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int n;
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter arr element");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // 7	0	0	0	5	6	7	5	0	7	5	3
            int firstcell = 0;
            int lastcell = 0;
            int maxDistance = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j] && (j - i - 1) > maxDistance)
                    {
                        maxDistance = j - i - 1;
                        firstcell = i;
                        lastcell = j;
                    }
                }
            }
            Console.WriteLine($"First cell index = {firstcell}, Last cell index = {lastcell}");
            Console.WriteLine("Longest Distance = " + maxDistance);




            //// task 2 
            //string str = Console.ReadLine();
            //string[] arr = str.Split(" ");
            //arr = arr.Reverse().ToArray();
            //string resault = string.Join(" ", arr);
            //Console.WriteLine(resault);

            //tASK 3 99999999


            //int counter = 0;
            //Stopwatch s1  = new Stopwatch();
            //s1.Start();
            //for (int i = 0; i < 99999999; i++)
            //{
            //    string str = i.ToString();

            //    for (int k = 0; k < str.Length; k++)
            //        if (str[k] == '1')
            //            counter++;
            //}
            //Console.WriteLine(counter);
            //s1.Stop();
            //Console.WriteLine($"  first sol finsh in {s1}");

            //Stopwatch s2 = new Stopwatch();
            //s2.Start();
            //int temp;
            //int j;
            //counter = 0;
            //for (int i = 0; i < 99999999; i++)
            //{
            //    j = i;
            //    while (j > 0)
            //    {
            //        temp = j % 10;
            //        if (temp == 1)
            //        {
            //            counter++;
            //        }
            //        j = j / 10;
            //    }

            //}
            //s2.Stop();
            //Console.WriteLine(counter);
            //Console.WriteLine($"  first sol finsh in {s2}");
            //Stopwatch s3 = new Stopwatch();
            //s3.Start();
            //Console.WriteLine(100000000*8 /10);
            //s3.Stop();
            //Console.WriteLine($"  first sol finsh in {s3}");
        }
    }
}
