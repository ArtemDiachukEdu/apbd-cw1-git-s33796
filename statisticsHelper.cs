namespace MyProject;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        double sum = 0;
        foreach (var v in values) sum += v;
        return sum / values.Length;
    }
    
    
    
    
    
    
    
}