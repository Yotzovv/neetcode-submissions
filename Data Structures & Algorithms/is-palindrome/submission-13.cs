public class Solution {
    public bool IsPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            while (!char.IsLetterOrDigit(s[l]) && l < r) l++;   //L=0
            while (!char.IsLetterOrDigit(s[r]) && r > l) r--;   //R=s.Length-1

            if (char.ToLower(s[l]) != char.ToLower(s[r])) return false;

            l += 1;
            r -= 1;
        }
        
        return true;
    }
}
