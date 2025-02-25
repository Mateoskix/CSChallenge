public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = [];
        List<int> subset = [];
        LeafSearch(nums, 0, subset, res);
        return res;
    }

    private static void LeafSearch(int[] nums, int i, List<int> subset, IList<IList<int>> res)
    {
        if (i >= nums.Length)
        {
            res.Add(new List<int>(subset));
            return;
        }

        subset.Add(nums[i]);
        LeafSearch(nums, i+1, subset, res);

        subset.RemoveAt(subset.Count - 1);
        LeafSearch(nums, i+1, subset, res);
    }
}