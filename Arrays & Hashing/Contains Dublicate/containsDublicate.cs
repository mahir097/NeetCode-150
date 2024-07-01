public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        
        foreach (int num in nums) {
            if (set.Contains(num)) {
                return true;
            }
         
            set.Add(num);
        }
     
        return false;
    }
}

// Testler
int[] nums1 = {1, 2, 3, 1};
Console.WriteLine(new Solution().ContainsDuplicate(nums1)); // true
int[] nums2 = {1, 2, 3, 4};
Console.WriteLine(new Solution().ContainsDuplicate(nums2)); // false
int[] nums3 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
Console.WriteLine(new Solution().ContainsDuplicate(nums3)); // true
