
namespace Leetcode.Array
{
    public class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {         
            int state = 0;

            bool IsNotValid(int bit)
            {
                if ((state >> bit & 1) > 0)
                    return true; 

                state |= 1 << bit;       
                return false;
            }

            for (int i = 0; i < 9; i++)  
            {
                for (int j = 0; j < 9; j++)         
                {            
                    if (board[i][j] != '.') 
                        if (IsNotValid(board[i][j] - '1'))   
                            return false;
                
                    if (board[j][i] != '.')
                        if (IsNotValid(board[j][i] - '1' + 9)) 
                            return false;
                 
                    int y = j / 3 + (i / 3) * 3;     
                    int x = j % 3 + (i % 3) * 3;      
                    if (board[y][x] != '.')
                        if (IsNotValid(board[y][x] - '1' + 18)) 
                            return false;
                }

                state = 0;
            }

            return true;
        }
    }
}
