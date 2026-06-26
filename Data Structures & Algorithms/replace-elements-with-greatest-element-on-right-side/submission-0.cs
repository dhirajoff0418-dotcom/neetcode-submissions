public class Solution {
    public int FindMax(int[] arr, int start)
    {
        int max = arr[start];

        for (int i = start + 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        return max;
    }
    public int[] ReplaceElements(int[] arr) {
       for(int i=0;i <arr.Length-1;i++){
            int max=FindMax(arr, i + 1);
            arr[i]=max;
       }
       arr[arr.Length - 1] = -1;
       return arr;
        
    }
}