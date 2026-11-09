public class Solution {
    public bool CheckInclusion(string s1, string s2) // s1="hello", s2="ooolleoooleh"
    {
        for (var l = 0; l <= s2.Length - s1.Length; l++)
        {
            // lec,eca,caa,aab,abe,bee
            var substr = s2.Substring(l, s1.Length); 
            Console.WriteLine(substr);
            if (IsPermutation(s1, substr)) return true;
        }

        return false;
    }

     private bool IsPermutation(string s1, string substr)
    {
        var ht = new Dictionary<char, int>();       // {h:1},{e:1},{l:2},{o:1}
        foreach (var c in s1)
        {
            if (!ht.ContainsKey(c)) ht.Add(c, 1);
            else ht[c]++;
        }
        
        // s1=hello  s2=ooleh
        foreach (var c in substr)
        {
            if (!ht.TryGetValue(c, out var n) || n == 0) return false;
            ht[c] = n - 1;
        }
        
        return true;
    }
}
