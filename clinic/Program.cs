using clinic;
using clinic.Entities;
using BusinessLogic;

internal class Program
{
    private static void Main(string[] args)
    {
        UserInteraction userInteraction = new UserInteraction(args[0]);
    }
}