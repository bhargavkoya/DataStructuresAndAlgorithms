/*
Consider a rat placed at (0, 0) in a square matrix of order N * N. It has to reach the destination at (N - 1, N - 1). Find all possible paths that the rat can take to reach from source to destination. The directions in which the rat can move are 'U'(up), 'D'(down), 'L' (left), 'R' (right). Value 0 at a cell in the matrix represents that it is blocked and rat cannot move to it while value 1 at a cell in the matrix represents that rat can be travel through it.
Note: In a path, no cell can be visited more than one time. If the source cell is 0, the rat cannot move to any other cell.

Example 1:

Input:
N = 4
m[][] = {{1, 0, 0, 0},
         {1, 1, 0, 1}, 
         {1, 1, 0, 0},
         {0, 1, 1, 1}}
Output:
DDRDRR DRDDRR
Explanation:
The rat can reach the destination at 
(3, 3) from (0, 0) by two paths - DRDDRR 
and DDRDRR, when printed in sorted order 
we get DDRDRR DRDDRR.
Example 2:
Input:
N = 2
m[][] = {{1, 0},
         {1, 0}}
Output:
-1
Explanation:
No path exists and destination cell is 
blocked.
Your Task:  
You don't need to read input or print anything. Complete the function printPath() which takes N and 2D array m[ ][ ] as input parameters and returns the list of paths in lexicographically increasing order. 
Note: In case of no path, return an empty list. The driver will output "-1" automatically.

Expected Time Complexity: O((3N^2)).
Expected Auxiliary Space: O(L * X), L = length of the path, X = number of paths.


*/
//class findPath
//{
//      private static void solve(int i, int j, int a[,], int n, ArrayList < String > ans, String move,
//        int vis[,], int di[], int dj[]) {
//        if (i == n - 1 && j == n - 1) {
//          ans.Add(move);
//          return;
//        }
//        String dir = "DLRU";
//        for (int ind = 0; ind < 4; ind++) {
//          int nexti = i + di[ind];
//          int nextj = j + dj[ind];
//          if (nexti >= 0 && nextj >= 0 && nexti < n && nextj < n &&
//            vis[nexti,nextj] == 0 && a[nexti,nextj] == 1) {
    
//            vis[i,j] = 1;
//            solve(nexti, nextj, a, n, ans, move + dir[ind], vis, di, dj);
//            vis[i,j] = 0;
    
//           }
//       }
//    }

//    public static List<IList<String>> findPathCal(int[,] m, int n) {
//        // Your code here
//            int vis[,] = new int[n,n];
//        for (int i = 0; i < n; i++) {
//          for (int j = 0; j < n; j++) {
//            vis[i,j] = 0;
//          }
//        }
//        int di[] = {
//          +1,
//          0,
//          0,
//          -1
//        };
//        int dj[] = {
//          0,
//          -1,
//          1,
//          0
//        };
//        List<IList < String > ans = new lIST<iList<string>> ();
//        if (m[0,0] == 1) solve(0, 0, m, n, ans, "", vis, di, dj);
//        return ans;

//    }
//}