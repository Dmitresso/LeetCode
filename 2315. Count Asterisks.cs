public class Solution {
    public int CountAsterisks(string s) {
        int counter = 0;
        bool inside = false;
        
        foreach (char c in s) {
            switch (c) {
                case '|':
                    inside = !inside;
                    break;
                case '*':
                    if (!inside) counter++;
                    break;
            }
        }
        return counter;
    }
}