public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int low = 0;
        int high = (m * n) - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int row = mid / n;
            int col = mid % n;

            int value = matrix[row][col];

            if (value == target)
            {
                return true;
            }
            else if (value < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return false;
    }
}