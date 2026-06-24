public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int l = nums.Length;
        int[] product = new int[l];
        int totalProduct = 1;
        int zeroCount = 0;
        for (int i = 0; i < l; i++)
        {
            if (nums[i] != 0)
            {
                totalProduct *= nums[i];
            }
            else
            {
                zeroCount++;
            }
        }

    for (int i = 0; i < l; i++)
    {
            if (zeroCount > 1)
            {
                product[i] = 0;
            }
            else if (zeroCount == 1)
            {
                product[i] = nums[i] == 0 ? totalProduct : 0;
            }
            else
            {
                product[i] = totalProduct / nums[i];
            }
    }

    return product;
    }

}
