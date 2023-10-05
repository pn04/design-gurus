using design_gurus;

namespace design_gurus_tests;

public class TwoPointersTests
{
    //write a test for TwoSum

    [Fact]
    public void TwoSumTest()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;
        //act
        var result = twoPointers.TwoSum(nums, target);
        //assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSumTest2()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 26;
        //act
        var result = twoPointers.TwoSum(nums, target);
        //assert
        Assert.Equal(new int[] { 2, 3 }, result);
    }

    [Fact]
    public void TwoSumSortedTest1()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { 1, 2, 3, 4, 6 };
        var target = 6;
        //act
        var result = twoPointers.TwoSumSorted(nums, target);
        //assert
        Assert.Equal(new int[] { 1, 3 }, result);
    }

    [Fact]
    public void TwoSumSortedTest2()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { 2, 5, 9, 11 };
        var target = 11;
        //act
        var result = twoPointers.TwoSumSorted(nums, target);
        //assert
        Assert.Equal(new int[] { 0, 2 }, result);
    }

    [Fact]
    public void RemoveDuplicatesTest1()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { 2, 3, 3, 3, 6, 9, 9 };
        //act
        var result = twoPointers.RemoveDuplicates(nums);
        //assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void RemoveDuplicatesTest2()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { 2, 2, 2, 11 };
        //act
        var result = twoPointers.RemoveDuplicates(nums);
        //assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void SortedSquaresTest1()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -2, -1, 0, 2, 3 };
        //act
        var result = twoPointers.SortedSquares(nums);
        //assert
        Assert.Equal(new int[] { 0, 1, 4, 4, 9 }, result);
    }

    [Fact]
    public void SortedSquaresTest2()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -3, -1, 0, 1, 2 };
        //act
        var result = twoPointers.SortedSquares(nums);
        //assert
        Assert.Equal(new int[] { 0, 1, 1, 4, 9 }, result);
    }

    [Fact]
    public void SortedSquaresTest3()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -5, -3, -2, -1 };
        //act
        var result = twoPointers.SortedSquares(nums);
        //assert
        Assert.Equal(new int[] { 1, 4, 9, 25 }, result);
    }

    [Fact]
    public void SortedSquaresTest4()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -1, 0 };
        //act
        var result = twoPointers.SortedSquares(nums);
        //assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void ThreeSumTest1()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -3, -1, 0, 1, 2 };
        //act
        var result = twoPointers.ThreeSum(nums);
        //assert
        Assert.Equal(new List<List<int>> { new List<int> { -3, 1, 2 }, new List<int> { -1, 0, 1 } }, result);
    }

    [Fact]
    public void ThreeSumTest2()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -5, 2, -1, -2, 3 };
        //act
        var result = twoPointers.ThreeSum(nums);
        //assert
        Assert.Equal(new List<List<int>> { new List<int> { -5, 2, 3 }, new List<int> { -2, -1, 3 } }, result);
    }

    [Fact]
    public void ThreeSumClosestTest1()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -2, 0, 1, 2 };
        var target = 2;
        //act
        var result = twoPointers.ThreeSumClosest(nums, target);
        //assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void ThreeSumClosestTest2()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -3, -1, 1, 2 };
        var target = 1;
        //act
        var result = twoPointers.ThreeSumClosest(nums, target);
        //assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void ThreeSumClosestTest3()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { 1, 0, 1, 1 };
        var target = 100;
        //act
        var result = twoPointers.ThreeSumClosest(nums, target);
        //assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void ThreeSumSmallerTest1()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -2, 0, 1, 3 };
        var target = 2;
        //act
        var result = twoPointers.ThreeSumSmaller(nums, target);
        //assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void ThreeSumSmallerTest2()
    {
        //arrange
        var twoPointers = new TwoPointers();
        var nums = new int[] { -1, 4, 2, 1, 3 };
        var target = 5;
        //act
        var result = twoPointers.ThreeSumSmaller(nums, target);
        //assert
        Assert.Equal(4, result);
    }
}
