/*
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
*/
public class IsValidSudoku
{
    public bool IsValidSudokuCal(char[][] board) {
        HashSet<string> hresult = new HashSet<string>();
        
        for(int i=0; i < 9; i++){
            for(int j=0; j< 9; j++){
                if(board[i][j] != '.'){
                    
                //Check whether HashSet contains duplicate elements in row and column 
                if(hresult.Contains("row" + i + board[i][j]) || hresult.Contains("col" + j + board[i][j]) ){
                    return false;
                }
                hresult.Add("row" + i + board[i][j]);
                hresult.Add("col" + j + board[i][j]);
                
                
                //Check whether Box contains duplicate elements in it
                if(hresult.Contains("box"+ (i/3) + (j/3) + board[i][j])){
                    return false;
                }
                hresult.Add("box"+ (i/3) + (j/3) + board[i][j]);
                }
            }
        }
        
        
        return true;

    }
}