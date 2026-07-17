// https://leetcode.com/problems/can-place-flowers

namespace CanPlaceFlowers;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1 && flowerbed[0] == 1) return false;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            var isTheFirstPot = i == 0;
            var isTheLastPot = i == flowerbed.Length - 1;

            var case1 = isTheFirstPot &&
                flowerbed[i] + flowerbed[i + 1] == 0;

            var case2 = !isTheFirstPot && !isTheLastPot &&
                flowerbed[i - 1] + flowerbed[i] + flowerbed[i + 1] == 0;

            var case3 = isTheLastPot &&
                flowerbed[i] + flowerbed[i - 1] == 0;

            var canPlaceFlower = case1 || case2 || case3;

            if (canPlaceFlower)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        return n <= 0;
    }
}
