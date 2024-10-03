namespace MathLib.PartOne;

public static class Sign
{
    public static void GetSignOfNumber(int number)
    {
        // On a number line, if you have C (at -2) to the left of 0,
        // b at 1 and a at 2, the order is C, 0, b, a.
        var absoluteValue = Math.Abs(number);
        
        // A positive number divided by its absolute value is 1.
        // A negative number divided by its absolute value is -1.
        
        // If negative, the number is being compared to it's positive counterpart.
        var direction = number / absoluteValue;
    }
}