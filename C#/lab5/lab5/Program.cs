
namespace lab5
{
    
    struct emp (int ID ) { }
    internal class Program
    {

        static void Main(string[] args)
        {

            #region class 
            Point3D p2 = new Point3D();
            Point3D p1 = new Point3D(10, 10, 10);
            Point3D p3 = new Point3D(15, 14, 10);
            Point3D p4 = new Point3D(15, 10, 10);
            Point3D[] arr = { p1, p2 ,p3 ,p4 };

            Console.WriteLine(" ----Before Sort ----");

            for (int i = 0; i < arr.Length; i++) { 
              Console.WriteLine(arr[i]);
            }

            Array.Sort(arr);

            Console.WriteLine(" ----After Sort ----");
            for (int i = 0; i < arr.Length; i++) { 
                Console.WriteLine(arr[i]);
            }
            //Console.WriteLine(P);
            //Point3D p1 = null, p2 = null;
            //int x, y, z;
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($" point {i + 1}");
            //    do
            //    {
            //        Console.WriteLine("Enter X ");
            //    } while (!int.TryParse(Console.ReadLine(), out x));

            //    do
            //    {
            //        Console.WriteLine("Enter Y ");
            //    } while (!int.TryParse(Console.ReadLine(), out y));

            //    do
            //    {
            //        Console.WriteLine("Enter Z ");
            //    } while (!int.TryParse(Console.ReadLine(), out z));

            //    if (i == 0)
            //        p1 = new Point3D(x, y, z);
            //    else
            //        p2 = new Point3D(x, y, z);
            //}

            //Console.WriteLine("P1: " + p1);
            //Console.WriteLine("P2: " + p2);

            //if (p1.Equals(p2))
            //    Console.WriteLine(" equal ");
            //else
            //    Console.WriteLine(" not Equal ");
            #endregion 

            #region static 
            //Console.WriteLine(Math.Add(10, 5));
            //Console.WriteLine(Math.Subtract(10, 5));
            //Console.WriteLine(Math.Multiply(10, 5));
            //Console.WriteLine(Math.Divide(10, 5));
            #endregion


            #region singlton
            //NIC nic1 = NIC.GetInstance("P1", "MAC1", NICType.Ethernet);

            //NIC nic2 = NIC.GetInstance("P2", "MQC2", NICType.TokenRing);
            //Console.WriteLine($"NIC1: {nic1.Manufacture}, {nic1.MACAddress}, {nic1.Type}");
            //Console.WriteLine($"NIC2: {nic2.Manufacture}, {nic2.MACAddress}, {nic2.Type}");
            #endregion

            #region Duration
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());

            //D3 = D1 + D2;
            //Console.WriteLine($"D3 = D1 + D2: {D3}");

            //D3 = D1 + 7800;
            //Console.WriteLine($"D3 = D1 + 7800: {D3}");

            //D3 = 666 + D3;
            //Console.WriteLine($"D3 = 666 + D3: {D3}");

            //D3 = D1++;
            //Console.WriteLine($"D3 = D1++: {D3}");
            //Console.WriteLine($"D1 now  {D1}");
            //D3 = --D2;
            //Console.WriteLine($"D3 = --D2: {D3}");



            //if (D1 > D2) Console.WriteLine("D1 > D2");
            //if (D1 <= D2) Console.WriteLine("D1 <= D2");
            //if (D1) Console.WriteLine("D1 is True (Positive)");

            //Duration D4 = new Duration(1, 1, 1);
            //DateTime Obj = (DateTime)D4;
            //Console.WriteLine($"DateTime Object: {Obj.ToLongTimeString()}");
            #endregion
        }




    }
}
