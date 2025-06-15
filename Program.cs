namespace StudentGradeSystem;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            MENUCONTROLLER.Main_Menu();
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Write("Invalid Input! Please enter a Number: ");
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
}