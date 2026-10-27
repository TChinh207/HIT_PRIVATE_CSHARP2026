using System;

class bai3
{
    static void Main()
    {
        int enemyCount;
        float totalSeconds;
        const int PointsPerEnemy = 150;
        do
        {
            Console.Write("Nhap so dich bi ha: ");
            enemyCount = int.Parse(Console.ReadLine());
        } while (enemyCount < 0 || enemyCount > 10000);
        do
        {
            Console.Write("Nhap tong thoi gian da choi: ");
            totalSeconds = float.Parse(Console.ReadLine());
        } while (totalSeconds < 1 || totalSeconds > 86400);
        Console.WriteLine("Diem: " + enemyCount * PointsPerEnemy);
        
    }
}

