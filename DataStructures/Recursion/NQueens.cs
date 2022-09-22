/*
The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.

Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.

Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.

 

Example 1:


Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
Example 2:

Input: n = 1
Output: [["Q"]]

*/
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        char[,] board = new char[n,n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                board[i,j] = '.';
        List<IList<string>> res = new List<IList<string>>();
        int[] leftRow = new int[n];
        int[] upperDiagonal = new int[2 * n - 1];
        int[] lowerDiagonal = new int[2 * n - 1];
        solve(0, board, res, leftRow, lowerDiagonal, upperDiagonal);
        return res;

    }
    
    public  void solve(int col, char[,] board, List <IList<string>> res, int[] leftRow, int[] lowerDiagonal, int[] upperDiagonal) {
        if (col == board.Length) {
            res.Add(construct(board));
            return;
        }

     for (int row = 0; row < board.Length; row++) {
        if (leftRow[row] == 0 && lowerDiagonal[row + col] == 0 && upperDiagonal[board.Length - 1 + col - row] ==0)             {
                board[row,col] = 'Q';
                leftRow[row] = 1;
                lowerDiagonal[row + col] = 1;
                upperDiagonal[board.Length - 1 + col - row] = 1;
                solve(col + 1, board, res, leftRow, lowerDiagonal, upperDiagonal);
                board[row,col] = '.';
                leftRow[row] = 0;
                lowerDiagonal[row + col] = 0;
                upperDiagonal[board.Length - 1 + col - row] = 0;
            }
        }
    }
    
    public  List<string> construct(char[,] board) {
        List<string> rs = new List<string>();
        for (int i = 0; i < board.Length; i++) {
            string s = new string("");
            for(int j=0;j<board.Length;j++)
            {
                if(board[i,j]=='Q')
                    s+='Q';
                else
                    s+='.';
                    
            }
            rs.Add(s);
        }
        return rs;
    }

    

}


/*------------------------------------------------------------------------------------------------------------------*/

public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        char[,] board = new char[n,n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                board[i,j] = '.';
        List<IList<string>> res = new List<IList<string>>();
        dfs(0,board,res,n);
        return res;

    }
    
    public bool validate(char[,] board, int row, int col) {
        int duprow = row;
        int dupcol = col;
        while (row >= 0 && col >= 0) {
            if (board[row,col] == 'Q') return false;
            row--;
            col--;
        }

        row = duprow;
        col = dupcol;
        while (col >= 0) {
            if (board[row,col] == 'Q') return false;
            col--;
        }

        row = duprow;
        col = dupcol;
        while (col >= 0 && row < board.Length) {
            if (board[row,col] == 'Q') return false;
            col--;
            row++;
        }
        return true;
    }

    
     public void dfs(int col, char[,] board, List <IList<string>> res,int n) {
        if (col == board.Length) {
            res.Add(construct(board,n));
            return;
        }

        for (int row = 0; row < board.Length; row++) {
            if (validate(board, row, col)) {
                board[row,col] = 'Q';
                dfs(col + 1, board, res,n);
                board[row,col] = '.';
            }
        }
    }
 
    public  List<string> construct(char[,] board,int n) {
        List<string> rs = new List<string>();
        for (int i = 0; i < n; i++) {
            string s = new string("");
            for(int j=0;j<n;j++)
            {
                if(board[i,j]=='Q')
                    s+='Q';
                else
                    s+='.';
                    
            }
            rs.Add(s);
        }
        return rs;
    }

    

}