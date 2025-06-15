namespace StudentGradeSystem;

class Services
{
    static public void Exit()
    {
        Console.WriteLine("\t Thanks For Using Our Application.");
        Console.WriteLine("Press Any Key to Complete Exit....");
        Console.ReadKey(true);
        return;
    }
    static public void DrawLine()
    {
        Console.WriteLine("+---------------------------------------------------+");
    }
}