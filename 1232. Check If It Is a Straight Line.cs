public class Solution {
    public bool CheckStraightLine(int[][] c) {
        if (c.Length <= 2) return true;

        int x = 0, y = 0,
            x1 = c[0][0],
            y1 = c[0][1],
            x2 = c[1][0],
            y2 = c[1][1];

        for (int i = 2; i < c.Length; i++) {
            x = c[i][0];
            y = c[i][1];

            if ((y2 - y1) * (x - x1) != (y - y1) * (x2 - x1)) return false;
        }
        return true;
    }
}