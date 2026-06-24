public class Solution {
    public bool IsPalindrome(string s) {
     string noSpaces = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
     int size=noSpaces.Length;
     int i=0;
     int j=size- 1;
     while(i<j){
        if (noSpaces[i] != noSpaces[j])
        {
            return false;
        }
        i++;
        j--;
     }
     return true;

    }
}
