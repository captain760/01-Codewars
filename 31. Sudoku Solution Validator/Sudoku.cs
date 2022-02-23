using System.Collections.Generic;
using System.Linq;

namespace _31._Sudoku_Solution_Validator
{
    public class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '0')
                    {
                        return false;
                    }
                }
            }
            //checking each row
            for (int i = 0; i < 9; i++)
            {
                Dictionary<int, int> nums = new Dictionary<int, int>
            {
                {1,0},
                {2,0},
                {3,0},
                {4,0},
                {5,0},
                {6,0},
                {7,0},
                {8,0},
                {9,0},
            };
                for (int j = 0; j < 9; j++)
                {
                    if (nums.Any(x => x.Key == board[i][j]))
                    {
                        nums[nums.Where(x => x.Key == board[i][j]).First().Key]++;
                    }
                }
                if (nums.Any(x => x.Value != 1))
                {
                    return false;
                }
            }
            // checking each column

            for (int i = 0; i < 9; i++)
            {
                Dictionary<int, int> nums = new Dictionary<int, int>
            {
                {1,0},
                {2,0},
                {3,0},
                {4,0},
                {5,0},
                {6,0},
                {7,0},
                {8,0},
                {9,0},
            };
                for (int j = 0; j < 9; j++)
                {
                    if (nums.Any(x => x.Key == board[j][i]))
                    {
                        nums[nums.Where(x => x.Key == board[j][i]).First().Key]++;
                    }
                }
                if (nums.Any(x => x.Value != 1))
                {
                    return false;
                }
            }
            //checking each internal squire
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    Dictionary<int, int> nums = new Dictionary<int, int>
            {
                {1,0},
                {2,0},
                {3,0},
                {4,0},
                {5,0},
                {6,0},
                {7,0},
                {8,0},
                {9,0},
            };
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            if (nums.Any(x => x.Key == board[i + k][j + l]))
                            {
                                nums[nums.Where(x => x.Key == board[i + k][j + l]).First().Key]++;
                            }
                        }
                    }
                    if (nums.Any(x => x.Value != 1))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
