public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{

    {/*dekho sbse pahle ek map banayege kyu ki isme hmstore kr payneg based on key value
    uske baad sbko chars ke array me convert kr denge and sort kr denge and then insert krte time
    check kreneg ki already insted hai ya ny */}
    Dictionary<string, List<string>> map =
        new Dictionary<string, List<string>>();

    foreach (string str in strs)
    {
        char[] chars = str.ToCharArray();

        Array.Sort(chars);

        string key = new string(chars);

        if (!map.ContainsKey(key))
        {
            map[key] = new List<string>();
        }

        map[key].Add(str);
    }

    return map.Values.ToList();
}
}
