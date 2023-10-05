namespace design_gurus;

//https://leetcode.com/problems/two-sum/
public class TwoPointers
{
    //nums = [2,7,11,15], target = 9 => [0,1]
    public int[] TwoSum(int[] nums, int target)
    {
        // int[] pair = new int[2];
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     var compliment = target - nums[i];
        //     var pairItem = Array.LastIndexOf(nums, compliment);
        //     if (pairItem != -1 && pairItem != i)
        //     {
        //         pair[0] = i;
        //         pair[1] = pairItem;
        //         return pair;
        //     }
        // }
        // return pair;
        Dictionary<int, int> compliments = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var currComplement = target - nums[i];
            if (compliments.ContainsKey(currComplement))
            {
                return new int[] { compliments[currComplement], i };
            }
            else
            {
                compliments[nums[i]] = i;
            }
        }
        throw new InvalidOperationException();
    }

    public int[] TwoSumSorted(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            if (arr[left] + arr[right] < target)
            {
                left++;
            }
            else if (arr[left] + arr[right] > target)
            {
                right--;
            }
            else
            {
                return new int[2] { left, right };
            }
        }
        return new int[2] { -1, -1 };
    }

    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    // 2,3,3,3,6,9,9 => 2,3,6,3,3,9,9
    // 2,2,2,3,4,5,5 
    public int RemoveDuplicates(int[] nums)
    {
        int nextUnique = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != nums[nextUnique - 1])
            {
                nums[nextUnique++] = nums[i];
            }
        }
        return nextUnique;
    }

    //-3, -1, 0, 1, 2 -> 0, 1, 1, 4, 9
    public int[] SortedSquares(int[] nums)
    {
        // int firstPos = 1; //got this from bin search
        // int negPos = firstPos - 1;
        // int[] res = new int[nums.Length];

        // for (int i = 0; i < res.Length; i++)
        // {
        //     if (firstPos < nums.Length && negPos >= 0)
        //     {
        //         int posSquare = nums[firstPos] * nums[firstPos];
        //         int negSquare = nums[negPos] * nums[negPos];
        //         if (posSquare < negSquare)
        //         {
        //             res[i] = posSquare;
        //             firstPos++;
        //         }
        //         else
        //         {
        //             res[i] = negSquare;
        //             negPos--;
        //         }
        //     }
        //     else if (firstPos >= nums.Length)
        //     {
        //         res[i] = nums[negPos] * nums[negPos];
        //         negPos++;
        //     }
        //     else
        //     {
        //         res[i] = nums[firstPos] * nums[firstPos];
        //         firstPos++;
        //     }
        // }
        // return res;
        int[] result = new int[nums.Length];
        int largestSquareIndex = nums.Length - 1;
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];
            if (leftSquare > rightSquare)
            {
                result[largestSquareIndex] = leftSquare;
                left++;
            }
            else
            {
                result[largestSquareIndex] = rightSquare;
                right--;
            }
            largestSquareIndex--;
        }
        return result;
    }

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> triplets = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            SearchPair(nums, -nums[i], i + 1, triplets);
        }
        return triplets;
    }

    private void SearchPair(int[] arr, int target, int left, IList<IList<int>> triplets)
    {
        int right = arr.Length - 1;
        while (left < right)
        {
            if (arr[left] + arr[right] == target)
            {
                triplets.Add(new int[3] { -target, arr[left], arr[right] });
                left++;
                right--;
                //skip duplicates
                while (left < right && arr[left] == arr[left - 1])
                {
                    left++;
                }
                while (left < right && arr[right] == arr[right + 1])
                {
                    right--;
                }
            }
            else if (arr[left] + arr[right] < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
    }

    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int minSumTriplet = int.MaxValue;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1, right = nums.Length - 1;
            while (left < right)
            {
                int currentSum = nums[i] + nums[left] + nums[right];
                if (currentSum == target)
                {
                    return currentSum;
                }
                else
                {
                    if (Math.Abs(currentSum - target) < Math.Abs(minSumTriplet - target)
                       || (Math.Abs(currentSum - target) == Math.Abs(minSumTriplet - target)) && currentSum < minSumTriplet)
                    {
                        minSumTriplet = currentSum;
                    }

                    if (currentSum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }
        return minSumTriplet;
    }

    public int ThreeSumSmaller(int[] nums, int target)
    {
        Array.Sort(nums);
        int tripletCount = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1, right = nums.Length - 1;
            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] < target)
                {
                    tripletCount += right - left;
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return tripletCount;
    }
}