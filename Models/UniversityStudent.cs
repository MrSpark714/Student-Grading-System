
namespace StudentGradeSystem;

class University_Student : Student
{
    public override void DisplayInfo()
    {
        Console.Clear();
        Services.DrawLine();
        Console.WriteLine("\t === Studdent Details ===");
        Console.WriteLine($"\nYour Full Name: {Name}");
        Console.WriteLine($"Your User Name: {UserName}");
        Console.WriteLine($"Your Institude is {Institude_Type}");
        Console.WriteLine("\n\t === Registration Successfully ===");
        Console.WriteLine("Press Any Key to Next Menu ....");
        Console.ReadKey(true);
    }
    public University_Student(string Name, string UserName, string Password, string Institude_Type)
    {
        this.Name = Name; this.UserName = UserName; this.Password = Password; this.Institude_Type = Institude_Type;
    }
}