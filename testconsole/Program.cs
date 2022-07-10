using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class RevenueMilestones
{
    static void Main(string[] args)
    {
        // Call getMilestoneDays() with test cases here
        var a  = getUniformIntegerCountInInterval(1, 999999999999);
        Console.WriteLine(a.ToString());
    }

    // Write any using statements here
    public static int getUniformIntegerCountInInterval(long A, long B)
    {
        // Write your code here
        long divisor = 1L;
        int countOfUniformNumbers = 0;
        for (long counter = A; counter <= B; counter = counter + divisor)
        {
            var digits = Convert.ToInt16(Math.Floor(Math.Log10(counter) + 1));
            divisor = GetDivisor(digits);
            var rem = (int)(counter % divisor);
            if (rem == 0)
            {
                countOfUniformNumbers++;
            }
            else
            {
                var additive = divisor - rem;
                if (counter + additive > B)
                {
                    break;
                }
                else
                {
                    counter += additive;
                    countOfUniformNumbers++;
                }
            }
        }
        return countOfUniformNumbers;
    }

    private static long GetDivisor(int digits)
    {
        string divisor = "1";
        for (int i = 1; i < digits; i++)
        {
            divisor = divisor + "1";
        }
        return Convert.ToInt64(divisor);
    }


}