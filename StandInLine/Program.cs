using System;
using System.Collections.Generic;
using System.Linq;

namespace StandInLine
{
    class Program
    {
        static int[] Reconstruct(int[] OldPositionOfSoldiers)
        {
            int[] NewPositionOfSoldiers = new int[OldPositionOfSoldiers.Length];

            List<int> availablePosition = Enumerable.Range(0, OldPositionOfSoldiers.Length).ToList();

            int SoldierNumber = 1;
            foreach (var position in OldPositionOfSoldiers)
            {
                NewPositionOfSoldiers[availablePosition[position]] = SoldierNumber++;
                availablePosition.RemoveAt(position);
            }
            return NewPositionOfSoldiers;
        }
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            do
            {
                int[] left = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(string.Join(",", Array.ConvertAll<int, string>(Reconstruct(left), delegate (int s) { return s.ToString(); })));
                input = Console.ReadLine();
            } while (input != "-1");
        }
    }
}
