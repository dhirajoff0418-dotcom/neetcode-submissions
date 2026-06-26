public class Solution {
    public int[] PlusOne(int[] digits) {
        // Traverse from the last digit
        for (int i = digits.Length - 1; i >= 0; i--) {
            // If digit is less than 9, simply increment and return
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }

            // If digit is 9, make it 0 and continue
            digits[i] = 0;
        }

        // If all digits were 9, create a new array
        int[] ans = new int[digits.Length + 1];
        ans[0] = 1;

        return ans;
    }
}