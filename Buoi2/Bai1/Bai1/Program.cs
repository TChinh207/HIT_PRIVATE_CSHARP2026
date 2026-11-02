using System;
class program
{
    static int CalculateDamage(int attack, int armor)
    {
        if (attack <= armor)
        {
            return 0;
        }
        else
        {
            return attack - armor;
        }
    }
    static int CalculateRemainingHp(int currentHp, int damage, int armor)
    {
        return currentHp - CalculateDamage(damage, armor);
    }
    static void Main()
    {
        int initialHp;
        int Hp;
        do
        {
            Console.Write("Nhap initial HP (1-1000): ");
            Hp = initialHp = int.Parse(Console.ReadLine());
        }

        while (initialHp < 1 || initialHp > 1000);
        int armor;
        do
        {
            Console.Write("Nhap armor (0-100): ");
            armor = int.Parse(Console.ReadLine());
        } while (armor < 0 || armor > 100);
        int n;
        do
        {
            Console.Write("Nhap so don tan cong n (1-100): ");
            n = int.Parse(Console.ReadLine());
        } while (n < 1 || n > 100);
        int[] dame = new int[n];
        for (int i = 0; i < n; i++)
        {
            dame[i] = int.Parse(Console.ReadLine());
        }
        int dem = 1;
        for (int i = 0; i < n; i++)
        {
            initialHp = CalculateRemainingHp(initialHp, dame[i], armor);
            if (initialHp <= 0)
            {
                Console.WriteLine("Don " + (i + 1) + ": Sat thuong " + CalculateDamage(dame[i], armor) + " | Hp 0");
                dem = dem;
                initialHp = 0;
                break;
            }
            else
            {
                Console.WriteLine("Don " + (i + 1) + ": Sat thuong " + CalculateDamage(dame[i], armor) + " | Hp " + initialHp);
                dem++;
            }
        }
        if (initialHp <= 0)
        {
            Console.WriteLine("Trang Thai: Da bi ha");
        }
        else
        {
            Console.WriteLine("Trang Thai: Con Song");
        }
        Console.WriteLine("So don da xu ly: " + dem);
        Console.WriteLine("Tong HP da mat: " + (Hp - initialHp));
        if (initialHp <= 0)
        {
            Console.WriteLine("Don Ket Lieu: " + dem);
        }
    }
}
