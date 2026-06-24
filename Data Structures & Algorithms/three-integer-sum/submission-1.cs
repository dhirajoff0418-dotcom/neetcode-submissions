public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        List<List<int>> resultArray = new List<List<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int low = i + 1;
            int high = nums.Length - 1;

            while (low < high)
            {
                int sum = nums[low] + nums[high] + nums[i];

                if (sum == 0)
                {
                    resultArray.Add(new List<int> { nums[i], nums[low], nums[high] });

                    low++;
                    high--;

                    while (low < high && nums[low] == nums[low - 1])
                        low++;

                    while (low < high && nums[high] == nums[high + 1])
                        high--;
                }
                else if (sum < 0)
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
        }

        return resultArray;
    }
}