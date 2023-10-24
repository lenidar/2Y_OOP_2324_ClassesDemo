using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_OOP_2324_ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] card = new int[5, 5];
            BingoCard bc = new BingoCard();
            card = bc.GenerateCard();

            for(int x = 0; x < card.GetLength(0); x++) 
            {
                for(int y = 0; y < card.GetLength(1); y++)
                {
                    Console.Write(card[x,y] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            Console.Clear();
            int[][,] cards = new int[5][,];

            for(int x = 0; x < cards.Length; x++)
            {
                cards[x] = bc.GenerateCard();
            }
        }
    }
}
