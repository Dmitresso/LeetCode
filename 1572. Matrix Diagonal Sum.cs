using System.Threading.Tasks;

public class Solution {
    public int DiagonalSum(int[][] mat) {
        if (mat.Length == 1) return mat[0][0];
        int sum = 0;
        Parallel.For(0, mat.Length, i => {
            for (int j = 0; j < mat[i].Length; j++) {
                if (j.Equals(i) || j.Equals(mat[i].Length - 1 - i)) sum += mat[i][j];
            }
        });
        return sum;
    }
}