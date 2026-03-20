using System;
using System.Linq;
using DAL.Context; // Reference to your DAL
using HotelManagment.Entities; // Reference to your Entities

namespace LAB_16_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new HotelContext())
            {
                try
                {
                    Console.WriteLine("Connecting to Database...");

                    // Attempt to fetch the first record from FrontendLog
                    var admin = db.Frontends.FirstOrDefault();

                    if (admin != null)
                    {
                        Console.WriteLine("Success!");
                        Console.WriteLine($"Found User: {admin.Username}");
                    }
                    else
                    {
                        Console.WriteLine("Connection successful, but the FrontendLog table is empty.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred:");
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}