public class Solution {

     public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();
        foreach (var str in strs)
            sb.Append(str.Length).Append("#").Append(str);
        
        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            var j = i;
            while (s[j] != '#') j++;
            int length = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j+1, length));
            
            i = j + 1 + length;
        }

        return result;
    }
}
