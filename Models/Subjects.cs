namespace StudentGradeSystem;

class Subject
{
    public int NumberOfSubjects { get; }
    private List<string> _subjectNames = new List<string>();
    private List<string> _subjectGrades = new List<string>();
    private List<int> _creditHours = new List<int>();

    public Subject(int numberOfSubjects)
    {
        NumberOfSubjects = numberOfSubjects;
    }

    public void AddSubjectWithGradeAndCreditHour(string subjectName, string grade, int credithours)
    {
        if (_subjectNames.Count >= NumberOfSubjects)
        {
            throw new InvalidOperationException("Cannot add more subjects than specified");
        }

        _subjectNames.Add(subjectName);
        _subjectGrades.Add(grade);
        _creditHours.Add(credithours);
    }

    public void DisplaySubjectsWithGrades()
    {
        Services.DrawLine();
        Console.WriteLine("\t === Subject Grades ===");
        Console.WriteLine("Subjects Name | Subjects Grades | Credit Hours");
        for (int i = 0; i < _subjectNames.Count; i++)
        {
            Console.WriteLine($"{_subjectNames[i]} | {_subjectGrades[i]} | {_creditHours[i]}");
        }
    }

}