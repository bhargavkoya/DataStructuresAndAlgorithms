public class Solution {
    public bool ValidTicTacToe(string[] board) {
        int cx=0, co=0;
          for(int i=0;i<3;i++)
          {
               for(int j=0;j<3;j++)
               {
                      if(board[i][j]=='X')
                          cx++;
                     else if(board[i][j]=='O')
                         co++;
               }
          }
        if(co> cx || (cx-co)>1)
            return false;
        bool winx= winning(board,'X');
        bool wino= winning(board,'O');
           
        if(winx && wino)
            return false;
        if(winx && cx==co)
            return false;
        if(wino && cx>co)
            return false;
        
        return true;
        
    }
     bool winning(string[] board, char ch)
    {
             if(board[0][0]==ch && board[0][1]==ch && board[0][2]==ch)
                 return true;
              if(board[1][0]==ch && board[1][1]==ch && board[1][2]==ch)
                 return true;
         if(board[2][0]==ch && board[2][1]==ch && board[2][2]==ch)
                 return true;
         if(board[0][0]==ch && board[1][0]==ch && board[2][0]==ch)
                 return true;
        if(board[0][1]==ch && board[1][1]==ch && board[2][1]==ch)
                 return true;
        if(board[0][2]==ch && board[1][2]==ch && board[2][2]==ch)
                 return true;
        if(board[0][0]==ch && board[1][1]==ch && board[2][2]==ch)
                 return true;
        if(board[2][0]==ch && board[1][1]==ch && board[0][2]==ch)
                 return true;
        return false;
    }

}