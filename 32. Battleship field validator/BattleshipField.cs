using System.Collections.Generic;
using System.Linq;

namespace BattleshipField
{
    public class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            Dictionary<int, int> ships = new Dictionary<int, int>
            {
                {4,1 },
                {3,2 },
                {2,3 },
                {1,4 }
            };
            List<int[]> zeroCells = new List<int[]>();
            for (int i = 0; i < 10; i++)
            {
                bool isFirst = false;
                for (int j = 0; j < 10; j++)
                {
                    if (IsValid(i, j - 1) && field[i, j - 1] == 0)
                    {
                        isFirst = false;
                    }
                    if (field[i, j] == 1 && isFirst == false)
                    {
                        if (((IsValid(i - 1, j) && field[i - 1, j] == 0)&& (IsValid(i - 1, j-1) && field[i - 1, j-1] == 0)&& (IsValid(i - 1, j + 1) && field[i - 1, j + 1] == 0) && (IsValid(i + 1, j - 1) && field[i + 1, j - 1] == 0)) || i == 0)
                        {
                            isFirst = true;
                            var point = new int[2] { i, j };
                            zeroCells.Add(point);
                        }
                    }

                }
            }
            foreach (var point in zeroCells)
            {
                int row = point[0];
                int col = point[1];
                //check horizontally
                if (IsValid(row, col + 1) && field[row, col + 1] == 1)
                {
                    if (IsValid(row, col + 2) && field[row, col + 2] == 1)
                    {
                        if (IsValid(row, col + 3) && field[row, col + 3] == 1)
                        {
                            if (IsValid(row + 1, col + 3) && field[row + 1, col + 3] == 0 && (IsValid(row, col + 4) && field[row, col + 4] == 0) && (IsValid(row+1, col + 4) && field[row+1, col + 4] == 0))
                            {
                                ships[4]--;
                            }
                            else return false;
                        }
                        else if (IsValid(row + 1, col + 2) && field[row + 1, col + 2] == 0)
                        {
                            ships[3]--;
                        }
                        else return false;
                    }
                    else if (IsValid(row + 1, col + 1) && field[row + 1, col + 1] == 0)
                    {
                        ships[2]--;
                    }
                    else return false;
                }
                else if ((IsValid(row + 1, col) && field[row + 1, col] == 0) && (IsValid(row - 1, col+1) && field[row - 1, col+1] == 0)&& (IsValid(row + 1, col+1) && field[row + 1, col+1] == 0))
                {
                    ships[1]--;
                }
                else
                // check vertically

                if (IsValid(row + 1, col) && field[row + 1, col] == 1)
                {
                    if (IsValid(row + 2, col) && field[row + 2, col] == 1)
                    {
                        if (IsValid(row + 3, col) && field[row + 3, col] == 1)
                        {
                            if (IsValid(row + 3, col + 1) && field[row + 3, col + 1] == 0 && (IsValid(row + 4, col) && field[row + 4, col] == 0) && (IsValid(row + 4, col+1) && field[row + 4, col+1] == 0))
                            {
                                ships[4]--;
                            }
                            else return false;
                        }
                        else if (IsValid(row + 1, col + 2) && field[row + 1, col + 2] == 0)
                        {
                            ships[3]--;
                        }
                        else return false;
                    }
                    else if (IsValid(row + 1, col + 1) && field[row + 1, col + 1] == 0)
                    {
                        ships[2]--;
                    }
                    else return false;
                }
                else if ((IsValid(row + 1, col) && field[row + 1, col] == 0) && (IsValid(row + 1, col-1) && field[row + 1, col-1] == 0) && (IsValid(row - 1, col - 1) && field[row - 1, col - 1] == 0))
                {
                    ships[1]--;
                }

            }


            if (ships.All(x => x.Value == 0))
            {
                return true;
            }
            return false;
        }

        private static bool IsValid(int row, int col) => row >= 0 && col >= 0 && row < 10 && col < 10;
    }
}
