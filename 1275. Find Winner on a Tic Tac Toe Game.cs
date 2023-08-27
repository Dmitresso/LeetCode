public class Solution {
    public Dictionary<string, uint> hexes = new Dictionary<string, uint>() {
            { "00", 0x80080080 }, { "01", 0x40008000 }, { "02", 0x20000808 },
            { "10", 0x08040000 }, { "11", 0x04004044 }, { "12", 0x02000400 },
            { "20", 0x00820002 }, { "21", 0x00402000 }, { "22", 0x00200220 },
    };

    public string Tictactoe(int[][] moves) {
        if (moves.Length < 5) return "Pending";
        uint res = 0;
        uint[] winMoves;

        if (moves.Length % 2 == 0) { // 6 / 8: means B winner or pending
            winMoves = WinMoves(1);
            for (int i = 0; i < winMoves.Length; i++) res |= winMoves[i];
            return (res & (res << 1) & (res >> 1)) == 0 ? "Pending" : "B";
        }
        else { // 5 / 7 means A winner or pending, 9 means A winner or draw
            winMoves = WinMoves(0);
            for (int i = 0; i < winMoves.Length; i++) res |= winMoves[i];
            return (res & (res << 1) & (res >> 1)) == 0 ? moves.Length == 9 ? "Draw" : "Pending" : "A";
        }

        uint[] WinMoves(int startIndex) {
            uint[] winnerMoves = new uint[moves.Length / 2 + 1];
            for (int i = startIndex, j = 0; i < moves.Length; i += 2) {
                if (hexes.TryGetValue(string.Join("", moves[i]), out var hex)) {
                    winnerMoves[j] = hex;
                    j++;
                }
            }
            return winnerMoves;
        }
    }
}