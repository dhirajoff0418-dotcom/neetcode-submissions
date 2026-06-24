public class Solution {
    public int MaxArea(int[] heights) {
        int h1=0;
        int h2=heights.Length-1;
        int area=0;
        while(h1<h2){
         int minHeight = Math.Min(heights[h1], heights[h2]);
         int w=h2-h1;
         int calarea=minHeight*w;
         if(calarea>area){
            area=calarea;
         }
         if(heights[h1]<heights[h2]){
            h1++;
         }else{
            h2--;
         }
        }
        return area ;
    }
}
