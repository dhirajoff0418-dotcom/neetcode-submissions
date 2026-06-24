public class Solution {
    public bool IsAnagram(string s, string t) {
      if(s.Length != t.Length){
        return false;
      }
      char[] charX = s.ToCharArray();
      Array.Sort(charX);
      s = new string(charX);

      char[] charT = t.ToCharArray();
      Array.Sort(charT);
      t = new string(charT);

      for(int i=0;i<s.Length;i++){
        if(s[i] !=t[i]){
            return false;
        }
      }
      return true ;
    }
}
