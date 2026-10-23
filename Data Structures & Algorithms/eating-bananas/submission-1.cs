public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var minSpeed = 1;
        var maxSpeed = piles.Max();
        var result = maxSpeed;
        
        while (minSpeed <= maxSpeed)
        {
            int k = (minSpeed + maxSpeed) / 2;
            var totalHoursNeeded = 0;

            foreach (var pile in piles)
            {
                totalHoursNeeded += (int)Math.Ceiling((double)pile / k);
            }

            if (totalHoursNeeded <= h)
            {
                result = k;
                maxSpeed = k - 1;
            }
            else
            {
                minSpeed = k + 1;
            }
        }

        return result;
    }
}
