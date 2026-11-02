using System;

class baitrenlop
{
    static void UsehealingPotion(int currentHP)
    {
        int[] potions = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
        int dem = 0;
        for (int i = 0; i < potions.Length; i++)
        {
            currentHP += potions[i];
            dem++;
            if (currentHP > 100)
            {
                currentHP = 100;
                break;
            }
        }
        Console.WriteLine("So luong binh mau da su dung: " + dem);
        Console.WriteLine("Hp hien tai: " + currentHP);
    }
    static void Main()
    {
        Console.Write("Nhap HP: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int currentHP))
        {
            Console.WriteLine($"HP vua nhap: {currentHP}");
        }
        else
        {
            Console.WriteLine("Du lieu khong phai so nguyen hop le.");
        }
        UsehealingPotion(currentHP);
        //int n;
        //int sum = 0;
        //n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    sum += i;
        //}
        //Console.WriteLine(sum);
        //Console.WriteLine(sum / n);
    }
}
