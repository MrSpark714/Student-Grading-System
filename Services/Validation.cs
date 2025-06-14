namespace StudentGradeSystem;

class Validation
{
    static public string GetValidName()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                Console.Write("Invalid Input! Try Again: ");
            }
        }
    }
    static public string GetValidPassword()
    {
        string password;
        bool isValid = false;
        do
        {
            password = ReadPassword();
            isValid = IsValidPassword(password);
            if (!isValid)
            {
                Console.WriteLine("Password must be at least 5 characters long!");
            }
        }
        while (!isValid);

        return password;
    }
    static private bool IsValidPassword(string password)
    {
        return password.Length >= 5;
    }
    static private string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, (password.Length - 1));
                Console.Write("\b \b"); // Erase the last *
            }
        }
        while (key.Key != ConsoleKey.Enter);

        return password;
    }
}