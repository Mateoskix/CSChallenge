public class Solution {
    public int LongestValidParentheses(string s) {
       int maxDiff = 0;
        Stack<int> stack = new Stack<int>();
        stack.Push(-1);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    stack.Push(i);
                }
                else
                {
                    maxDiff = Math.Max(maxDiff, i - stack.Peek());
                }
            }
        }

        return maxDiff;
    }
}