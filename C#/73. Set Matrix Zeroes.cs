public class Solution {
    public void SetZeroes(int[][] matrix) {
        List<int> rows = new List<int>(), columns = new List<int>();

        for (int i = 0; i < matrix.Length ; i++) {
            for (int j = 0; j < matrix[i].Length; j++) {
                if (matrix[i][j] != 0) continue;
                rows.Add(i);
                columns.Add(j);
            }
        }

        rows = rows.Distinct().ToList();
        columns = columns.Distinct().ToList();

        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[i].Length; j++) {
                if (columns.Contains(j)) matrix[i][j] = 0;
            }

            if (rows.Contains(i)) {
                Array.Clear(matrix[i], 0, matrix[i].Length);
                continue;
            }
        }  
    }
}