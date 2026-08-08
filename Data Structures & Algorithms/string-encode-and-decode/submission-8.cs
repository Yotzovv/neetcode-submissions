public class Solution {

    public string Encode(IList<string> strs) // strs=["Hello", "World"]
    {
        var sb = new StringBuilder();
        foreach (var str in strs)
        {
            sb.Append(str.Length).Append('#').Append(str);
        }
        
        return sb.ToString();   // 5#Hello5#World
    }

    public List<string> Decode(string s) // s= 5#Hello5#World
    {
        var list = new List<string>();
        var i = 0;

        while (i < s.Length)
        {
            var j = i;
            
            while (s[j] != '#') j++;
            var length = int.Parse(s.Substring(i, j-i));

            i = j + 1;

            var str = s.Substring(i, length);
            list.Add(str);
            i += length;
        }
        
        return list;
    }
}
