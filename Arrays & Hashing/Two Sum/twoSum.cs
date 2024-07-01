//Solution-1
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }

        return new int[0]; 
    }
}

// Testler
Solution solution = new Solution();
Console.WriteLine(string.Join(", ", solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9))); // [0, 1]
Console.WriteLine(string.Join(", ", solution.TwoSum(new int[] { 3, 2, 4 }, 6))); // [1, 2]
Console.WriteLine(string.Join(", ", solution.TwoSum(new int[] { 3, 3 }, 6))); // [0, 1]

//Solution-2

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }

        return new int[0]; 
    }
}

// Testler
Solution solution = new Solution();
Console.WriteLine(string.Join(", ", solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9))); // [0, 1]
Console.WriteLine(string.Join(", ", solution.TwoSum(new int[] { 3, 2, 4 }, 6))); // [1, 2]
Console.WriteLine(string.Join(", ", solution.TwoSum(new int[] { 3, 3 }, 6))); // [0, 1]
