namespace StudentGradeSystem;

class MENUCONTROLLER
{
    public static void Main_Menu()
    {
        Console.Clear();
        DrawLine();
        Console.WriteLine("\t === Student Grading System ===");
        Console.WriteLine("Here You can Track Your Grades and Scores.If you already \nRegister Your-Self Login and If Not Register First!\n");
        Console.WriteLine("\t1. Register Now.");
        Console.WriteLine("\t2. Log In. ");
        Console.WriteLine("\t3. Exit.");
        Console.Write("  Enter Your Choice: ");
    }
    public static void UniversityStudentMenu()
    {
        Console.Clear();
        DrawLine();
        Console.WriteLine("\t === University Students Menu ===");
        Console.WriteLine("1. See Your Personal Information.");
        Console.WriteLine("2. Add Semester.");
        Console.WriteLine("2. Add Subjects With Grades.");
        Console.WriteLine("3. Calculate Semester GPA.");
    }
    static private void DrawLine()
    {
        Console.WriteLine("+---------------------------------------------------+");
    }
}