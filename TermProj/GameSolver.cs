using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProj
{
    public class GameSolver
    {
       
        public  int[,] Solve( Index start)
        {
            int[,] arr = new int[5, 5];
            // set initial value
            Index i = start;

            arr[i.X, i.Y] = 1;
            for (int j = 2; j <= 25; j++)
            {
                Index closestIndex = GetClosestAvailableIndex(i, arr);
                if(closestIndex == null)
                {
                    break;
                }
                i = closestIndex;
                arr[closestIndex.X, closestIndex.Y] = j;
            }
            return arr;
        }

        private Index GetClosestAvailableIndex(Index p, int[,] arr)
        {
            List<Index> availableNeighborIndices = GetAvailableNeighborSlots(p, arr);
            if(availableNeighborIndices.Count > 0)
            {
                foreach (var index in availableNeighborIndices) //for each availblneighborindex
                {
                    index.MinDistance = GetMinDistance(index, arr);  //sets MinDistance property of indexes in availableNeighborINdices to the returned balue of GetminDistance, declared later

                }

                // after getting all minimum distances
                // choose the one which is minimum of all
               return availableNeighborIndices
                    .OrderBy(x => x.MinDistance).FirstOrDefault();

            }
            return p;
        }

        private List<Index> GetAvailableNeighborSlots(Index p, int[,] arr)
        {
            List<Index> indices = new List<Index>(); //creates list object indices

            int start = p.X - 1 >= 0 ? p.X - 1 : 0;
            int end = p.X + 1 <= 4 ? p.X + 1 : 4; //ternary: condition ? value if true : value if false

            // for X
            for (int i = start; i <= end; i++) //paths through the the array horizontally, looking from start to end
            {
                int x = i;
                int y = p.Y;
               
                if (x == p.X)
                {
                    continue;
                }
                if (arr[x, y] != 0)
                {
                    continue;
                }
                if (arr[x,y] == 0)
                {
                    indices.Add(new Index(i, p.Y));
                }
            }

            // y
            start = p.Y - 1 >= 0 ? p.Y - 1 : 0;
            end = p.Y + 1 <= 4 ? p.Y + 1 : 4;

            for (int i = start; i <= end; i++)
            {
                int x = p.X;
                int y = i;

                if (y == p.Y)
                {
                    continue;
                }
                if (arr[x, y] != 0)
                {
                    continue;
                }
                if (arr[x, y] == 0)
                {
                    indices.Add(new Index(x, y));
                }
            }

            return indices;
        }

        private int GetMinDistance(Index p, int[,] arr)
        {
            int up =0;
            int down = 0;
            int left = 0;
            int right = 0;

            // up
            for (int i = p.X; i >= 0; i--)
            {
                if(arr[i,p.Y] != 0)
                {
                    break;
                }
                else if (i == p.X)
                {
                    continue;
                }
                else if(arr[i, p.Y] == 0)
                {
                    up++;
                }
            }
            //down
            for (int i = p.X; i <= 4; i++)
            {
                if (arr[i, p.Y] != 0)
                {
                    break;
                }
                else if (i == p.X)
                {
                    continue;
                }
                else if (arr[i, p.Y] == 0)
                {
                    down++;
                }
            }
            //left
            for (int j = p.Y; j >= 0; j--)
            {
                if (arr[p.X, j] != 0)
                {
                    break;
                }
                else if (j == p.Y)
                {
                    continue;
                }
                else if (arr[p.X, j] == 0)
                {
                    left++;
                }
            }
            //right
            for (int j = p.Y; j <= 4; j++)
            {
                if (arr[p.X, j] != 0)
                {
                    break;
                }
                else if (j == p.Y)
                {
                    continue;
                }
                else if (arr[p.X, j] == 0)
                {
                    right++;
                }
            }

            List<int> directionValues = new List<int>
            {
                up , down ,left ,right
            };
            int min = up + down + left + right;
            //if (directionValues.Where(x => x > 0).Any()) 
            //{
            //    min = directionValues.Where(x => x > 0).Min();
            //}

            return min;
        } //end of GetMinDistance
    }
}
