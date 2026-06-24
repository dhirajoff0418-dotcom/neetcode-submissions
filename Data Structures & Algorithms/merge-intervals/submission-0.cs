public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals == null || intervals.Length == 0)
            return new int[0][];

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new List<int[]>();

        result.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] last = result[result.Count - 1];

            if (intervals[i][0] <= last[1])
            {
                last[1] = Math.Max(last[1], intervals[i][1]);
            }
            else
            {
                result.Add(intervals[i]);
            }
        }

        return result.ToArray();
    }
}