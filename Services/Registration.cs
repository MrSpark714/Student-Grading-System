namespace StudentGradeSystem;

class Registration
{
    public static void RegisterStudent()
    {
        Console.Clear();
        DrawLine();
        Console.WriteLine("\t === Registration Section === \n");
        Console.Write("Enter Your Full Name: ");

        string fullname = Validation.GetValidName();

        Console.Write("Enter Your Password: ");
        string Password = Validation.GetValidPassword();

        
    }
    static private void DrawLine()
    {
        Console.WriteLine("+---------------------------------------------------+");
    }
}