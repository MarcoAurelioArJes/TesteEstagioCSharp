public class MathUtils
{
    public static double Average(double a, double b) { 
        return (a + b) / 2;
    }

    public static void Main(string[] args) {
        Console.WriteLine(Average(2, 1)); // 1,5
    }
}