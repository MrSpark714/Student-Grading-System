namespace StudentGradeSystem;

class Registration
{
    public static void RegisterStudent()
    {
        Console.Clear();
        Services.DrawLine();
        Console.WriteLine("\t === Registration Section === \n");
        Console.Write("Enter Your Full Name: ");
        string fullname = Validation.GetValidName();

        Console.Write("Enter User Name (Spaces Not Alow): ");
        string username = Validation.GetValidUserName();

        Console.Write("Enter Your Password (Atleast 5 Character): ");
        string Password = Validation.GetValidPassword();
        while (true)
        {
            Console.WriteLine("Select Institude Type: ");
            Console.WriteLine("1. University Student.");
            Console.WriteLine("2. College Student.");
            Console.WriteLine("3. School Student.");
            Console.Write("Enter Your Choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Input! Please enter a Number: ");
                continue;
            }
            switch (choice)
            {
                case 1:
                    // Uni Student
                    University_Student s = new University_Student(fullname, username, Password, "University Student");
                    s.DisplayInfo();
                    return;
                case 2:
                    // College Student
                    break;
                case 3:
                    // School Student
                    break;
                case 4:
                    Services.Exit();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}