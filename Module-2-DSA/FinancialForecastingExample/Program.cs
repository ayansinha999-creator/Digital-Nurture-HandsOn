class FinancialForecast
{
    public static double FutureValue(double currentValue, double growthRate, int years)
    {
        if (years == 0)
        {
            return currentValue;
        }

        return FutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
    }
}

class Program
{
    static void Main()
    {
        double currentValue = 10000;
        double growthRate = 0.10;
        int years = 3;

        double result = FinancialForecast.FutureValue(
            currentValue,
            growthRate,
            years
        );

        Console.WriteLine("Future Value: " + result.ToString("F2"));
    }
}