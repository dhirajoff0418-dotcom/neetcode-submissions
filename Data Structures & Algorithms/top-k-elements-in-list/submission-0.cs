public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> fre = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            if (fre.ContainsKey(num)) {
                fre[num]++;
            } else {
                fre[num] = 1;
            }
        }
        var sorted = fre.OrderByDescending(x => x.Value);
        return sorted.Take(k).Select(x => x.Key).ToArray();
    }
}
