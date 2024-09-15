class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
        CircularArray.Solution solution = new CircularArray.Solution();
        Console.WriteLine(solution.CircularArrayLoop([-1,-2,-3,-4,-5,6]));
    }
}