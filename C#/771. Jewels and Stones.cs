using System.Linq;

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int result = 0;
        jewels.ToList().ForEach(j => result += stones.Count(c => c == j));
        return result;
    }
}