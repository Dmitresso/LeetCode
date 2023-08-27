public class Solution {
    public bool JudgeCircle(string moves) {
        int h = 0, v = 0;
        foreach (char c in moves) {
            switch (c) {
                case 'D': h--; break;
                case 'L': v--; break;
                case 'R': v++; break;
                case 'U': h++; break;
            }
        }
        return v == 0 && h == 0;
    }
}