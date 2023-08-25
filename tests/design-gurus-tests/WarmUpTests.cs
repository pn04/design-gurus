using design_gurus;

namespace design_gurus_tests;

public class WarmUpTests
{
    //write a test for ContainsDuplicate

    [Fact]
    public void ContainsDuplicateTest()
    {
        //arrange
        var warmUp = new WarmUp();
        var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        //act
        var result = warmUp.ContainsDuplicate(arr);
        //assert
        Assert.False(result);
    }

    [Fact]
    public void ContainsDuplicateTest2()
    {
        //arrange
        var warmUp = new WarmUp();
        var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1 };
        //act
        var result = warmUp.ContainsDuplicate(arr);
        //assert
        Assert.True(result);
    }

    [Fact]
    public void IsPangramTest()
    {
        //arrange
        var warmUp = new WarmUp();
        var input = "The quick brown fox jumps over the little lazy dog";
        //act
        var result = warmUp.IsPangram(input);
        //assert
        Assert.True(result);
    }

    [Fact]
    public void IsPangramTest2()
    {
        //arrange
        var warmUp = new WarmUp();
        var input = "The quick brown fox jumps --- ***** @ 34 90over the cat";
        //act
        var result = warmUp.IsPangram(input);
        //assert
        Assert.False(result);
    }

    [Fact]
    public void SquareRootTest()
    {
        //arrange
        var warmUp = new WarmUp();
        var num = 16;
        //act
        var result = warmUp.SquareRoot(num);
        //assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void SquareRootTest2()
    {
        //arrange
        var warmUp = new WarmUp();
        var num = 30;
        //act
        var result = warmUp.SquareRoot(num);
        //assert
        Assert.Equal(5, result);
    }

    // write a test for ReverseVowels that reverses only vowels in a strig
    [Fact]
    public void ReverseVowelsTest()
    {
        //arrange
        var warmUp = new WarmUp();
        var str = "hello";
        //act
        var result = warmUp.ReverseVowels(str);
        //assert
        Assert.Equal("holle", result);
    }

    [Fact]
    public void ReverseVowelsTest2()
    {
        //arrange
        var warmUp = new WarmUp();
        var str = "leetcode";
        //act
        var result = warmUp.ReverseVowels(str);
        //assert
        Assert.Equal("leotcede", result);
    }

    [Fact]
    public void IsValidPalindromeTest()
    {
        var warmUp = new WarmUp();
        var str = "Was it a car or a cat I saw?";

        var result = warmUp.IsValidPalindrome(str);
        Assert.True(result);
    }

    [Fact]
    public void IsValidPalindromeTest2()
    {
        var warmUp = new WarmUp();
        var str = "0P";

        var result = warmUp.IsValidPalindrome(str);
        Assert.False(result);
    }

    [Fact]
    public void IsValidPalindromeTest3()
    {
        var warmUp = new WarmUp();
        var str = "race a car";

        var result = warmUp.IsValidPalindrome(str);
        Assert.False(result);
    }

    [Fact]
    public void IsAnagramTest()
    {
        var warmUp = new WarmUp();
        var str1 = "anagram";
        var str2 = "nagaram";

        var result = warmUp.IsAnagram(str1, str2);
        Assert.True(result);
    }

    [Fact]
    public void IsAnagramTest2()
    {
        var warmUp = new WarmUp();
        var str1 = "rat";
        var str2 = "car";

        var result = warmUp.IsAnagram(str1, str2);
        Assert.False(result);
    }

    [Fact]
    public void ShortestDistanceTest1()
    {
        var warmUp = new WarmUp();
        var words = new string[] { "practice", "makes", "perfect", "coding", "makes" };
        var word1 = "coding";
        var word2 = "practice";

        var result = warmUp.ShortestDistance(words, word1, word2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void ShortestDistanceTest2()
    {
        var warmUp = new WarmUp();
        var words = new string[] { "practice", "makes", "perfect", "coding", "makes" };
        var word1 = "makes";
        var word2 = "coding";

        var result = warmUp.ShortestDistance(words, word1, word2);
        Assert.Equal(1, result);
    }

    [Fact]
    public void NoOfGoodPairsTest1()
    {
        var warmUp = new WarmUp();
        var nums = new int[] { 1, 2, 3, 1, 1, 3 };

        var result = warmUp.NumberOfGoodPairs(nums);
        Assert.Equal(4, result);
    }

    [Fact]
    public void NoOfGoodPairsTest2()
    {
        var warmUp = new WarmUp();
        var nums = new int[] { 1, 1, 1, 1 };

        var result = warmUp.NumberOfGoodPairs(nums);
        Assert.Equal(6, result);
    }

}
