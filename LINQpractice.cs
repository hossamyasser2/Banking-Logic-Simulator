using System;
class Program
{
    static void Main(string[] args)
    {
        List<int> scores = [97, 92, 81, 60];

        for (int i = 0; i < scores.Count; i++)
        {
            if(scores[i] > 80)
            {
                System.Console.WriteLine($"Found a score over 80 that is {scores[i]}");
            }
        }
        







    }
}