using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_OOP_2324_ClassesDemo
{
    internal class BingoCard
    {
        private int[,] _cardNums = new int[5, 5];
        private Random _rnd = new Random();

        /// <summary>
        /// This method will generate a bingo card
        /// </summary>
        /// <returns>the generated card</returns>
        public int[,] GenerateCard()
        {
            List<int> colNums = new List<int>();
            int temp = 0;

            InitializeCard();

            for(int y = 0; y < _cardNums.GetLength(1); y++) 
            {
                colNums = InitializeList();
                for(int x = 0; x < _cardNums.GetLength(0); x++)
                {
                    temp = _rnd.Next(0, colNums.Count);
                    _cardNums[x, y] = colNums[temp] + (15 * y);
                    colNums.RemoveAt(temp);
                }
            }

            return _cardNums;
        }

        private void InitializeCard()
        {
            for(int x = 0; x < _cardNums.GetLength(0); x++) 
            {
                for(int y = 0;  y < _cardNums.GetLength(1); y++) 
                {
                    _cardNums[x, y] = 0;
                }
            }
        }

        private List<int> InitializeList()
        {
            List<int> temp = new List<int>();
            for (int x = 0; x < 15; x++)
                temp.Add(x + 1);
            return temp;
        }
    }
}
