namespace StudentGradeSystem;

class MENUCONTROLLER
{
    public static void Main_Menu()
    {
        while (true)
        {
            Console.Clear();
            DrawLine();
            Console.WriteLine("\t === Student Grading System ===");
            Console.WriteLine("Here You can Track Your Grades and Scores.If you already Register Your-Self Login and If Not Register First!\n");
            Console.WriteLine("\t1. Register Now.");
            Console.WriteLine("\t2. Log In. ");
            Console.WriteLine("\t3. Exit.");
            Console.Write("  Enter Your Choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Input! Please enter a Number: ");
                continue;
            }
            switch (choice)
            {
                case 1:
                    Registration.RegisterStudent();
                    break;
                case 2:
                    // Log In Proccess
                    break;
                case 3:
                    Services.Exit();
                    Environment.Exit(0);
                    break;
            }
        }
    }
    static void RegistationMenu()
    {
        Console.Clear();
        DrawLine();
        Console.WriteLine("\t === Registation Section ===");
    }
    static private void DrawLine()
    {
        Console.WriteLine("+---------------------------------------------------+");
    }
}