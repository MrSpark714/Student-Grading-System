namespace StudentGradeSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\tChoose one Option");
        Console.WriteLine("\t1. University Student.");
        Console.WriteLine("\t2. School/College Student.");
        Console.WriteLine("\t3. Exit.");     
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Input! Please enter a Number: ");
            }
        switch (choice)
        {
            case 1:
                Console.WriteLine("University Student.");
                break;
            case 2:
                Console.WriteLine(" School/College Student.");
                break;
            case 3:
                Console.WriteLine("Exit.");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;    
        }
        
    }
}