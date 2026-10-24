using System;
using EFCoreExample.Data;

namespace EFCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khoi tao ung dung EF Core...");
            
            using (var context = new AppDbContext())
            {
                // Kiem tra xem co the ket noi toi DB khong
                bool canConnect = context.Database.CanConnect();
                Console.WriteLine($"Ket noi Database thanh cong: {canConnect}");
            }
        }
    }
}
