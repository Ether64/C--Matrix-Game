using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProj
{
    public class Game
    {
        #region PrivateFields
        private int[,] grid;
        private const int rows=5;
        private const int cols=5;
        private int predecessor = 1;
        private Index predecessorIndex;
        private bool isReverted = false;
        private bool isWon = false;
        private bool isLost = false;

        #endregion
        public Game()
        {
            grid = new int[rows,cols];
        }

        public void Initialize()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 5);
            int y = rnd.Next(0, 5);

            grid[x, y] = 1;
            StartIndex = new Index(x, y);
            predecessorIndex = StartIndex;

        }
        public bool Proceed(Index i)
        {
            #region Unused Validations
            // check range

            //if (val == 1)
            //{
            //    ErrorMessage = "Can't Add Starting value multiple times";
            //    return false;
            //}

            //if (val < 2 || val > 25)
            //{
            //    ErrorMessage = "Can't Add value outside limits (2-25)";
            //    return false;
            //}

            //if (Exists(val))
            //{
            //    ErrorMessage = "Can't Add Same value multiple times";
            //    return false;
            //}

            //if (val != predecessor + 1)
            //{
            //    ErrorMessage = "Please Enter a Number next to the predecessor";
            //    return false;
            //}
            #endregion

            if (!IsInRangeOfPredecessor(i))
            {
                ErrorMessage = "Please Enter a Number in diagonal region of its predecessor";
                return false;
            }

            // after processing
            predecessor = predecessor + 1;
            grid[i.X, i.Y] = predecessor;


            predecessorIndex = i;

            isReverted = false;
            ProcessGameOver();
            return true;
        }
        public bool Revert()
        {
            if (!isReverted)
            {
                // check if predecessor is greater than 1
                if (predecessor == 1)
                {
                    ErrorMessage = "Cannot Revert Initial Value , to Reset the Game Press Abort";
                    return false;
                }
                // neglect 1 from predecessor 
                predecessor = predecessor - 1;
                // get index by value 
                predecessorIndex = GetPredecessorIndex();
                // mark the move reverted
                isReverted = true;
                return true;
            }
            else
            {
                ErrorMessage = "Cannot Revert More than 1 Move";
                return false;
            }
        }

        private Index GetPredecessorIndex()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(grid[i,j] == predecessor)
                    {
                        return new Index(i, j);
                    }
                }
            }

            return StartIndex;
        }
        private void ProcessGameOver()
        {
            if (predecessor == 25)
            {
                isWon = true;
                return;
            }

            // check diagonals of current predecessor , if there is no spot left to fill then its game over
            isLost = true;
            for (int i = predecessorIndex.X - 1; i <= predecessorIndex.X + 1; i++)
            {
                for (int j = predecessorIndex.Y - 1; j <= predecessorIndex.Y + 1; j++)
                {
                    int x = i;
                    int y = j;
                    if (x < 0)
                    {
                        x = 0;
                    }
                    if (x >= rows)
                    {
                        x = rows - 1;
                    }
                    if (y < 0)
                    {
                        y = 0;
                    }
                    if (y >= cols)
                    {
                        y = cols - 1;
                    }

                    if(grid[x,y] == 0)
                    {
                        isLost = false;
                        break;
                    }
                }
            }

           
        }

        /// <summary>
        /// Checks If the given value is in the diagonal range of its predecessor
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool IsInRangeOfPredecessor(Index target)
        {
            // first get the index of predecessor
            for (int i = predecessorIndex.X - 1; i <= predecessorIndex.X + 1; i++)
            {
                for (int j = predecessorIndex.Y - 1; j <= predecessorIndex.Y + 1; j++)
                {
                    int x = i;
                    int y = j;
                    if(x < 0)
                    {
                        x = 0;
                    }
                    if(x >= rows)
                    {
                       x = rows - 1;
                    }
                    if (y < 0)
                    {
                        y = 0;
                    }
                    if (y >= cols)
                    {
                        y = cols - 1;
                    }

                    if (target.Equals(new Index(x, y)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        
        #region Properties
        public int Predecessor { get { return predecessor; } }
        public int[,] Grid { get { return grid; } }
        public int Rows { get { return rows; } }
        public int Cols { get { return cols; } }
        public int NextValue { get { return predecessor + 1; } }
        public Index StartIndex { get; set; }
        public string ErrorMessage { get; set; }
        public Index PredecessorIndex { get { return predecessorIndex; } }
        public bool IsWon { get { return isWon; } }
        public bool IsLost { get { return isLost; } }
        public int GameplayTime { get; set; }
        public DateTime BeginDate { get; set; }
        public string PlayerName { get; set; } = "";
        public string GameName { get; set; }
        #endregion



    }
}
