using System;

class bai2
{
    static void Main()
    {
        Console.Write("Nhap Ten Nhan Vat: ");
        string name = Console.ReadLine();
        int hp;
        float spd;
        do
        {
            Console.Write("Nhap HP: ");
            hp = int.Parse(Console.ReadLine());
        } while (hp < 0 || hp > 1000);
        do {
            Console.Write("Nhap Toc đo: ");
            spd = float.Parse(Console.ReadLine());
        } while (spd < 0 || spd > 100);
        Console.Write("Nhap Hang: ");
        string rank = Console.ReadLine();
        bool isAlive = hp > 0;
        Console.WriteLine("Ten: " + name);
        Console.WriteLine("HP: "+ hp);
        Console.WriteLine("Toc Do: " + spd);
        Console.WriteLine("Hang: " + rank);
        Console.WriteLine("Con Song: " + isAlive);
    }
}

