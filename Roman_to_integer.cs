public class Solution {
    public int RomanToInt(string s) {
        int val = 0;
        int result = 0;
        int nxtVal = 0;
        Dictionary<char, int> romans = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        for (int i = 0; i < s.Length; i++)
        {
            val = romans[s[i]];
            if (i + 1 < s.Length) nxtVal = romans[s[i+1]];

            if(i + 1 < s.Length && nxtVal > val)
            {
                result -= val;
            }
            else
            {
                result += val;
            }
        }

        return result;
    }
}