// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        IList<bool> output = [];
        var major = candies.Max();

        foreach (var candy in candies) output = [.. output, candy + extraCandies >= major];

        return output;
    }
}
