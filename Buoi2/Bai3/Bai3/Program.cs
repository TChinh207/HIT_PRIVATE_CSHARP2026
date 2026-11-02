using System;
class Program
{
    static int CalculateScore(int kills, int assists)
    {
        int points = kills * 100 + assists * 30;
        return points;
    }
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Nhap So luong nguoi choi: ");
            n = int.Parse(Console.ReadLine());

        } while (n <= 2);
        string[] players = new string[n];
        int[] kills = new int[n];
        int[] assists = new int[n];
        int[] scores = new int[n];
        int maxScore = scores[0];
        for (int i =0; i < n; i++)
        {
            Console.Write("Nhap Ten Player "+ (i + 1) + ": ");
            players[i] = Console.ReadLine();
            Console.Write("Nhap So Kill cua Player "+ (i + 1) + ": ");
            kills[i] = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Ho Tro cua Player "+ (i + 1) + ": ");
            assists[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem cua Player " + players[i] + " la: " + CalculateScore(kills[i], assists[i]));
            scores[i] = CalculateScore(kills[i], assists[i]); 
            if(scores[i] > maxScore)
            {
                maxScore = scores[i];
            }
        }
        for(int i = 0; i < n; i++)
        {
            if (scores[i] == maxScore)
            {
                Console.WriteLine("Player co diem cao nhat la: " + players[i]);
                Console.WriteLine("Diem cua Player " + players[i] + " la: " + scores[i]);
                break;
            }
        }
    }
}
