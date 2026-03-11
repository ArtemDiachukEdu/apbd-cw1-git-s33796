namespace MyProject;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        double sum = 0;
        foreach (var v in values) sum += v;
        return sum / values.Length;
    }
    
    public static int CalculateMax(int[] values)
    {
        int max = values[0];
        foreach (var v in values) if (v > max) max = v;
        return max;
    }
    
    public static int GetMin(int[] values)
    {
            int min = values[0];
            foreach (var v in values) if (v < min) min = v;
            return min;
    }
    
    
    
}