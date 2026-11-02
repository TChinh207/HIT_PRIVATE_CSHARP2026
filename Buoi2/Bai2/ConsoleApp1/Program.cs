using System;
class program
{
    static int CalculateTotalDamage(int[] damages,int n)
    {
        int totalDamage = 0;
        for (int i = 0; i < n; i++)
        {
            totalDamage += damages[i];
        }
        return totalDamage;
    }
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Nhap so don danh:");
            n = int.Parse(Console.ReadLine());
        }while(n <= 0);
        int[]dame = new int[n];
        int trung = 0;
        int truot = 0;
        int maxdame = dame[0];
        for (int i = 0; i < n; i++)
        {
                do
                {
                    dame[i] = int.Parse(Console.ReadLine());
                    if(dame[i] < 0)
                    {
                        Console.Write("Nhap lai sat thuong:");
                    }
                } while(dame[i] < 0);
                if(dame[i] == 0)
                {
                    truot++;
                }
                else if (dame[i] > 0)
                {
                    trung++;
                }
                if(dame[i] > maxdame)
                {
                    maxdame = dame[i];
                }
        }
        Console.WriteLine("Tong Sat Thuong: " + CalculateTotalDamage(dame, n));
        Console.WriteLine("So lan trung: " + trung);
        Console.WriteLine("So lan truot: " + truot);
        Console.WriteLine("Sat Thuong Lon Nhat: " + maxdame);
    }
}
