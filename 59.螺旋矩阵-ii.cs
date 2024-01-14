/*
 * @lc app=leetcode.cn id=59 lang=csharp
 *
 * [59] 螺旋矩阵 II
 */

// @lc code=start
public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] array = new int[n][];
        for (int a = 0; a < n; a++)
        {
            array[a]=new int[n];
        }//创建n*n的二维数组
        int count = 1;
        int loop = 0;
        int i,j = 0;
        while (loop < n/2)
        {
            i = loop;
            for ( j = loop; j < n-loop-1; j++)
            {
                array[i][j]= count++;
            }
            for (; i < n-loop-1; i++)
            {
                array[i][j]= count++;
            }
            for (; j > loop ;j--)
            {
                array[i][j]= count++;
            }
            for (; i > loop ;i--)
            {
                array[i][j]= count++;
            }
            loop++;
        }
        if(n%2!=0) array[loop][loop]=count;
        return array;
    }
}
// @lc code=end

