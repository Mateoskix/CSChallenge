public class Solution {
    public string ReverseWords(string s) {
        string[] text = s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
        return string.Join(" ", text);
    }
}