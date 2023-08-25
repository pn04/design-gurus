namespace design_gurus;
using System.Linq;

public class WarmUp
{
    //https://www.designgurus.io/course-play/grokking-the-coding-interview/doc/63d8efe7f8694f3655d60712
    public bool ContainsDuplicate(int[] arr)
    {
        // this could be done using brute force, we run two loops and compare each element in the inner loop with current element from outer loop
        //but that's bruteforce, another approach is:
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (set.Contains(arr[i]))
            {
                return true;
            }
            set.Add(arr[i]);
        }
        return false;
    }

    //https://www.designgurus.io/course-play/grokking-the-coding-interview/doc/63d923d6647c5c53032694bc
    public bool IsPangram(string input)
    {
        // approach 1
        // var alphabets = "abcdefghijklmnopqrstuvwxyz";
        // for (int i = 0; i < alphabets.Length; i++)
        // {
        //     if (!input.Contains(alphabets[i])) return false;
        // }
        // return true;

        // approach 2
        HashSet<char> alphabets = new HashSet<char>();
        for (int i = 0; i < input.ToLower().Length; i++)
        {
            if (Char.IsLetter(input[i]))
            {
                alphabets.Add(input[i]);
            }
        }
        return alphabets.Count >= 26;
    }

    //https://www.designgurus.io/course-play/grokking-the-coding-interview/doc/63d8fcaae8462840e6bde243
    public int SquareRoot(int num)
    {
        if (num <= 1) return 1;
        int low = 1, high = num, mid;

        while (low <= high)
        {
            mid = (low + high) / 2;
            if (mid * mid > num)
            {
                high = mid - 1;
            }
            else if (mid * mid < num)
            {
                low = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return high;
    }

    //https://www.designgurus.io/course-play/grokking-the-coding-interview/doc/63d9b8744bb2155485a195e9
    public string ReverseVowels(string str)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        // Queue<char> vowelQueue = new Queue<char>();
        // char[] strArray = str.ToCharArray();
        // for (int i = 0; i < str.Length; i++)
        // {
        //     if (vowels.Contains(str[i]))
        //     {
        //         strArray[i] = '*';
        //         vowelQueue.Enqueue(str[i]);
        //     }
        // }

        // for (int i = str.Length - 1, j = 0; i >= 0; i--)
        // {
        //     if (strArray[i] == '*')
        //     {
        //         strArray[i] = vowelQueue.Dequeue();
        //     }
        // }
        // return String.Join("", strArray);

        var resultArr = str.ToCharArray();
        int start = 0, end = str.Length - 1;
        while (start <= end)
        {
            if (vowels.Contains(str[start]) && vowels.Contains(str[end]))
            {
                (resultArr[end], resultArr[start]) = (resultArr[start], resultArr[end]);
                start++; end--;
            }
            else if (vowels.Contains(str[start]))
            {
                end--;
            }
            else
            {
                start++;
            }
        }
        return String.Join("", resultArr);
    }

    //A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
    public bool IsValidPalindrome(string s)
    {
        s = s.ToLowerInvariant();
        int start = 0, end = s.Length - 1;
        while (start <= end)
        {
            if (Char.IsLetterOrDigit(s[start]) && Char.IsLetterOrDigit(s[end]))
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                else
                {
                    start++; end--;
                }
            }
            else if (Char.IsLetterOrDigit(s[start]))
            {
                end--;
            }
            else
            {
                start++;
            }
        }
        return true;
    }

    /// <summary>
    /// https://leetcode.com/problems/valid-anagram/
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                map[s[i]]++;
            }
            else
            {
                map.Add(s[i], 1);
            }
        }
        for (int i = 0; i < t.Length; i++)
        {
            if (map.ContainsKey(t[i]))
            {
                map[t[i]]--;
            }
            else
            {
                return false;
            }
        }
        foreach (int freq in map.Values)
        {
            if (freq != 0) return false;
        }
        return true;
    }

    //Given an array of strings words and two different strings that already exist in the array word1 and word2, return the shortest distance between these two words in the list.
    public int ShortestDistance(string[] words, string word1, string word2)
    {
        //[["a", "c", "d", "b", "a"]
        int shortestDistance = words.Length;
        int start = -1, end = -1;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word1)
            {
                start = i;
            }
            if (words[i] == word2)
            {
                end = i;
            }
            if (start != -1 && end != -1)
            {
                shortestDistance = Math.Min(shortestDistance, Math.Abs(end - start));
            }
        }
        return shortestDistance;
    }

    //Given an array of integers nums, return the number of good pairs.A pair (i, j) is called good if nums[i] == nums[j] and i < j.
    public int NumberOfGoodPairs(int[] nums)
    {
        //{ 1, 2, 3, 1, 1, 3 }
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        int pairCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (freqMap.ContainsKey(nums[i]))
            {
                //each new enty can make pairs equal to the number of existing entries
                pairCount += freqMap[nums[i]];
                freqMap[nums[i]]++;
            }
            else
            {
                freqMap.Add(nums[i], 1);
            }
        }
        return pairCount;
    }
}
