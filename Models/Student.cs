namespace StudentGradeSystem;

abstract class Student
{
    #region Protected fields
    protected string _name;
    protected int _rollnumber;
    protected string _institudeType;
    #endregion

    #region Public Properties
    public string Name
    {
        get{return _name;} set{_name = value;} 
    }
    public int Roll_Number
    {
        get{return _rollnumber;} set{_rollnumber = value;} 
    }
    public string Institude_Type
    {
        get{return _institudeType;} set{_institudeType = value;} 
    }
    #endregion

    #region Abstract Methods
    public abstract void DisplayInfo();
    #endregion
}