public class Solution {
    public string MergeAlternately(string word1, string word2) {
            string final = "";
            int i = 0, j = 0, w1l = word1.Length, w2l = word2.Length;
            for (; i < w1l && j < w2l; i++, j++) {
                final += word1[i];
                final += word2[j];
            }
            if (i != w1l) final += word1.Substring(i);
            if (j != w2l) final += word2.Substring(j);
            
            return final;
    }
}