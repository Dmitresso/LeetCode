public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0;
        sentences.ToList().ForEach(s => { var c = s.Split(' ').Count(); if (c > max) max = c; });
        return max;
    }
}