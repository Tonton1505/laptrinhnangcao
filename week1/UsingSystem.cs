using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());

        int b = 0;
        while (true)
        {
            try
            {
                Console.Write("Nhap so b: ");
                b = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Loi! Nhap lai so b.");
            }
        }

        bool k = true;
        while (true)
        {
            try
            {
                Console.Write("Nhap so c: ");
                int c = int.Parse(Console.ReadLine());

                int tong = a + b + c;
                Console.WriteLine($"Tong 3 so la: {tong}");
                break;
            }
            catch (Exception)
            {
                k = false;
                Console.WriteLine($"Trang thai bien k = {k} (Nhap sai c). Vui long nhap lai!");
            }
        }

        Console.ReadLine();
    }
}
