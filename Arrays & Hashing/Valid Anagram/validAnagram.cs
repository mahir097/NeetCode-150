//Solution-1 Harfleri sıralayarak karşılaştırma

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray) == new string(tArray);
    }
}

// Testler
Solution solution = new Solution();
Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // true
Console.WriteLine(solution.IsAnagram("rat", "car")); // false


//Solution-2 Harfleri Sayarak Karşılaştırma

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char c in s) {
            if (count.ContainsKey(c)) {
                count[c]++;
            } else {
                count[c] = 1;
            }
        }

        foreach (char c in t) {
            if (!count.ContainsKey(c) || count[c] == 0) {
                return false;
            }
            count[c]--;
        }

        return true;
    }
}

// Testler
Solution solution = new Solution();
Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // true
Console.WriteLine(solution.IsAnagram("rat", "car")); // false
