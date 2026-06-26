public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        // Max Heap banane ke liye priority negative rakhenge
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        // Har element ko push krnege heap me
        foreach (int stone in stones)
        {
            pq.Enqueue(stone, -stone);
        }

        while (pq.Count > 1)
        {
            // 2 bar pop kyu ki 2 heaviset chahiye
            int y = pq.Dequeue();
            int x = pq.Dequeue();

            //smash logic
            if (y != x)
            {
                pq.Enqueue(y - x, -(y - x));
            }
        }

        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
}