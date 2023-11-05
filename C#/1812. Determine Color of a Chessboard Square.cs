public class Solution {
    public bool SquareIsWhite(string c) => (c[0] - 97 + (int) char.GetNumericValue(c[1])) % 2 == 0;
}